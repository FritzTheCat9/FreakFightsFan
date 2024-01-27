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

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class ImportFighterImagesFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/import", async (
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new ImportFighterImages.ImportFighterImagesCommand();
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<ImportFighterImages.ImportFighterImagesCommand, Unit>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;
            private readonly IWebHostEnvironment _webHostEnvironment;
            private readonly ImageOptions _options;
            private const string _textFieldCssSelector = "#__layout > div > div > div.page > div.dinamic-wrapper > div.search > div > form > div > div > input[type=text]";
            private const string _searchButtonCssSelector = "#__layout > div > div > div.page > div.dinamic-wrapper > div.search > div > form > div > button";
            private const string _downloadButtonCssSelector = "div > div:nth-child(1) > div > div.sf-downloadbtn";

            public Handler(
                IFighterRepository fighterRepository,
                IClock clock,
                IImageService imageService,
                IWebHostEnvironment webHostEnvironment,
                IOptions<ImageOptions> options)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
                _imageService = imageService;
                _webHostEnvironment = webHostEnvironment;
                _options = options.Value;
            }

            public async Task<Unit> Handle(
                ImportFighterImages.ImportFighterImagesCommand command,
                CancellationToken cancellationToken)
            {
                var fighters = await _fighterRepository.GetAll();
                var fullDriverPath = Path.GetFullPath(_webHostEnvironment.ContentRootPath);

                using (var driver = new ChromeDriver(fullDriverPath))
                {
                    foreach (var fighter in fighters)
                    {
                        if (fighter.Image is not null)
                        {
                            Console.WriteLine($"[IMAGE EXISTS] - Image for fighter: {fighter.Id} - Fighter already have image");
                            Console.WriteLine($"[END] - Image for fighter: {fighter.Id} - {fighter.FirstName} {fighter.LastName} {fighter.Nickname}");
                            continue;
                        }

                        Console.WriteLine($"[START] - Image for fighter: {fighter.Id} - {fighter.FirstName} {fighter.LastName} {fighter.Nickname}");

                        var nick = fighter.InstagramUrl?.Replace("https://www.instagram.com/", "")?.Replace("/", "");

                        if (string.IsNullOrEmpty(nick))
                        {
                            Console.WriteLine($"[NO INSTAGRAM] - Image for fighter: {fighter.Id} - Fighter instagram nick is null or empty: '{nick}'");
                            Console.WriteLine($"[END] - Image for fighter: {fighter.Id} - {fighter.FirstName} {fighter.LastName} {fighter.Nickname}");
                            continue;
                        }

                        driver.Navigate()
                              .GoToUrl(_options.ImportWebsite);

                        try
                        {
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
                            Console.WriteLine($"[NO BUTTON] - Image for fighter: {fighter.Id} - : Button error");
                            Console.WriteLine($"[END] - Image for fighter: {fighter.Id} - {fighter.FirstName} {fighter.LastName} {fighter.Nickname}");
                            continue;
                        }

                        var downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
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
                                Console.WriteLine($"[FILE] - Image for fighter: {fighter.Id} - Downloaded profile image with name {newestFile.Name}");

                                var fileBytes = File.ReadAllBytes(newestFile.FullName);
                                var imageBase64 = Convert.ToBase64String(fileBytes);
                                var contentType = MimeTypesMap.GetMimeType(newestFile.Extension);
                                var dataUrl = $"data:{contentType};base64,{imageBase64}";

                                fighter.Image = _imageService.UpdateEntityImage(fighter.Image, dataUrl);
                                await _fighterRepository.Update(fighter);
                                await _fighterRepository.SaveChanges();

                                Console.WriteLine($"[UPDATED] - Image for fighter: {fighter.Id} - Updated fighter image");

                                newestFile.Delete();

                                Console.WriteLine($"[DELETED] - Image for fighter: {fighter.Id} - Deleted downloaded image");
                            }
                            else
                            {
                                Console.WriteLine($"[NO FILE] - Image for fighter: {fighter.Id} - No profile image downloaded");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"[NO FILE] - Image for fighter: {fighter.Id} - No profile image downloaded");
                        }

                        Console.WriteLine($"[END] - Image for fighter: {fighter.Id} - {fighter.FirstName} {fighter.LastName} {fighter.Nickname}");
                    }
                }

                return Unit.Value;
            }
        }
    }
}
