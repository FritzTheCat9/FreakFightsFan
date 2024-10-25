using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using MediatR;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using HeyRed.Mime;
using Microsoft.Extensions.Options;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Api.Helpers;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class ImportFighterImagesFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/import", async (
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new ImportFighterImages.ImportFighterImagesCommand();
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags(Tags.Images)
                .RequireAuthorization(Policy.Admin);
        }

        public class Handler : IRequestHandler<ImportFighterImages.ImportFighterImagesCommand, Unit>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;
            private readonly IWebHostEnvironment _webHostEnvironment;
            private readonly ILogger<Handler> _logger;
            private readonly ImageOptions _options;
            private const string _textFieldCssSelector = "#__layout > div > div > div.page > div.dinamic-wrapper > div.search > div > form > div > div > input[type=text]";
            private const string _searchButtonCssSelector = "#__layout > div > div > div.page > div.dinamic-wrapper > div.search > div > form > div > button";
            private const string _downloadButtonCssSelector = "div > div:nth-child(1) > div > div.sf-downloadbtn";
            private const string _cookieDialog = "body > div.fc-consent-root > div.fc-dialog-container > div.fc-dialog.fc-choice-dialog > div.fc-footer-buttons-container > div.fc-footer-buttons > button.fc-button.fc-cta-consent.fc-primary-button > p";
            
            public Handler(
                IFighterRepository fighterRepository,
                IClock clock,
                IImageService imageService,
                IWebHostEnvironment webHostEnvironment,
                IOptions<ImageOptions> options,
                ILogger<Handler> logger)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
                _imageService = imageService;
                _webHostEnvironment = webHostEnvironment;
                _logger = logger;
                _options = options.Value;
            }

            public async Task<Unit> Handle(
                ImportFighterImages.ImportFighterImagesCommand command,
                CancellationToken cancellationToken)
            {
                var fighters = await _fighterRepository.GetAll();
                var fullDriverPath = Path.Combine(
                    Path.GetFullPath(_webHostEnvironment.ContentRootPath), 
                    "chromedriver",
                    OperatingSystem.IsLinux() ? "linux64" : "win64");

                using (var driver = new ChromeDriver(fullDriverPath))
                {
                    driver.Navigate()
                          .GoToUrl(_options.ImportWebsite);

                    var cookieDialog = driver.FindElement(By.CssSelector(_cookieDialog));
                    if (cookieDialog.Displayed)
                        cookieDialog.Click();

                    foreach (var fighter in fighters)
                    {
                        _logger.LogInformation("[IMPORT FIGHTERS - START] - Image for fighter: {FighterId} - {FighterFirstName} {FighterLastName} {FighterNickname}",
                            fighter.Id, fighter.FirstName, fighter.LastName, fighter.Nickname);

                        if (fighter.Image is not null)
                        {
                            _logger.LogInformation("[IMPORT FIGHTERS - IMAGE EXISTS] - Image for fighter: {FighterId} - Fighter already have image", fighter.Id);

                            _logger.LogInformation("[IMPORT FIGHTERS - END] - Image for fighter: {FighterId} - {FighterFirstName} {FighterLastName} {FighterNickname}",
                                fighter.Id, fighter.FirstName, fighter.LastName, fighter.Nickname);

                            continue;
                        }

                        var nick = fighter.InstagramUrl?.Replace("https://www.instagram.com/", "")?.Replace("/", "");

                        if (string.IsNullOrEmpty(nick))
                        {
                            _logger.LogInformation("[IMPORT FIGHTERS - NO INSTAGRAM] - Image for fighter: {FighterId} - Fighter instagram nick is null or empty: '{Nick}'",
                                fighter.Id, fighter.Nickname);

                            _logger.LogInformation("[IMPORT FIGHTERS - END] - Image for fighter: {FighterId} - {FighterFirstName} {FighterLastName} {FighterNickname}",
                                fighter.Id, fighter.FirstName, fighter.LastName, fighter.Nickname);

                            continue;
                        }

                        try
                        {
                            driver.Navigate()
                                  .GoToUrl(_options.ImportWebsite);

                            var textField = driver.FindElement(By.CssSelector(_textFieldCssSelector));
                            if (textField.Displayed)
                                textField.SendKeys(nick);

                            var searchButton = driver.FindElement(By.CssSelector(_searchButtonCssSelector));
                            if (searchButton.Displayed)
                                searchButton.Click();

                            Thread.Sleep(10000);

                            var downloadButton = driver.FindElement(By.CssSelector(_downloadButtonCssSelector));
                            if (downloadButton.Displayed)
                                downloadButton.Click();

                            Thread.Sleep(5000);
                        }
                        catch (Exception)
                        {
                            _logger.LogInformation("[IMPORT FIGHTERS - NO BUTTON] - Image for fighter: {FighterId} - Button error", fighter.Id);

                            _logger.LogInformation("[IMPORT FIGHTERS - END] - Image for fighter: {FighterId} - {FighterFirstName} {FighterLastName} {FighterNickname}",
                                fighter.Id, fighter.FirstName, fighter.LastName, fighter.Nickname);

                            continue;
                        }

                        var downloadsFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                        var targetDirectory = new DirectoryInfo(downloadsFolderPath);
                        var files = targetDirectory.GetFiles();

                        files = files.Where(file => !file.Attributes.HasFlag(FileAttributes.Directory)).ToArray();

                        if (files.Length > 0)
                        {
                            var newestFile = files.OrderByDescending(file => file.CreationTime)
                                                  .FirstOrDefault();
                            if (newestFile is not null && newestFile.CreationTime >= _clock.Current()
                                                                                           .AddMinutes(-1))
                            {
                                _logger.LogInformation("[IMPORT FIGHTERS - FILE] - Image for fighter: {FighterId} - Downloaded profile image with name {NewestFileName}",
                                    fighter.Id, newestFile.Name);

                                var fileBytes = await File.ReadAllBytesAsync(newestFile.FullName, cancellationToken);
                                var imageBase64 = Convert.ToBase64String(fileBytes);
                                var contentType = MimeTypesMap.GetMimeType(newestFile.Extension);
                                var dataUrl = $"data:{contentType};base64,{imageBase64}";

                                fighter.Image = _imageService.UpdateEntityImage(fighter.Image, dataUrl);
                                await _fighterRepository.Update(fighter);
                                await _fighterRepository.SaveChanges();

                                _logger.LogInformation("[IMPORT FIGHTERS - UPDATED] - Image for fighter: {FighterId} - Updated fighter image", fighter.Id);

                                newestFile.Delete();

                                _logger.LogInformation("[IMPORT FIGHTERS - DELETED] - Image for fighter: {FighterId} - Deleted downloaded image", fighter.Id);
                            }
                            else
                            {
                                _logger.LogInformation("[IMPORT FIGHTERS - NO FILE] - Image for fighter: {FighterId} - No profile image downloaded", fighter.Id);
                            }
                        }
                        else
                        {
                            _logger.LogInformation("[IMPORT FIGHTERS - NO FILE] - Image for fighter: {FighterId} - No profile image downloaded", fighter.Id);
                        }

                        _logger.LogInformation("[IMPORT FIGHTERS - END] - Image for fighter: {FighterId} - {FighterFirstName} {FighterLastName} {FighterNickname}",
                            fighter.Id, fighter.FirstName, fighter.LastName, fighter.Nickname);
                    }
                }

                return Unit.Value;
            }
        }
    }
}
