using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using MediatR;
using HeyRed.Mime;
using Microsoft.Extensions.Options;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Api.Helpers;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class ImportFederationImagesFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/import/federations", async (
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new ImportFederationImages.Command();
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags(Tags.Images)
                .RequireAuthorization(Policy.Admin);
        }

        public class Handler : IRequestHandler<ImportFederationImages.Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IImageService _imageService;
            private readonly IWebHostEnvironment _webHostEnvironment;
            private readonly ILogger<Handler> _logger;
            private readonly ImageOptions _options;

            public Handler(
                IFederationRepository federationRepository,
                IImageService imageService,
                IWebHostEnvironment webHostEnvironment,
                IOptions<ImageOptions> options, ILogger<Handler> logger)
            {
                _federationRepository = federationRepository;
                _imageService = imageService;
                _webHostEnvironment = webHostEnvironment;
                _logger = logger;
                _options = options.Value;
            }

            public async Task<Unit> Handle(
                ImportFederationImages.Command command,
                CancellationToken cancellationToken)
            {
                var federations = await _federationRepository.GetAll();
                const string extension = ".png";

                _logger.LogInformation("[IMPORT FEDERATIONS - START]");

                foreach (var federation in federations)
                {
                    var federation_image_name = Path.Combine(Path.GetFullPath(_webHostEnvironment.WebRootPath), _options.FederationImagesFolderName, $"{federation.Id}{extension}");
                    Console.WriteLine(federation_image_name);

                    try
                    {
                        var fileBytes = await File.ReadAllBytesAsync(federation_image_name, cancellationToken);
                        var imageBase64 = Convert.ToBase64String(fileBytes);
                        var contentType = MimeTypesMap.GetMimeType(extension);
                        var dataUrl = $"data:{contentType};base64,{imageBase64}";

                        federation.Image = _imageService.UpdateEntityImage(federation.Image, dataUrl);
                        await _federationRepository.Update(federation);
                    }
                    catch (Exception)
                    {
                        _logger.LogInformation("[IMPORT FEDERATIONS - NO IMAGE] - Federation (Id: {FederationId}, Name: {FederationName}) does not have image to seed", 
                            federation.Id, federation.Name);
                    }
                }

                _logger.LogInformation("[IMPORT FEDERATIONS - END]");

                return Unit.Value;
            }
        }
    }
}
