using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using HeyRed.Mime;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Images.Commands;

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

    public class Handler(
        IFederationRepository federationRepository,
        IImageService imageService,
        IWebHostEnvironment webHostEnvironment,
        IOptions<ImageOptions> options,
        ILogger<Handler> logger)
        : IRequestHandler<ImportFederationImages.Command, Unit>
    {
        private readonly ImageOptions _options = options.Value;

        public async Task<Unit> Handle(
            ImportFederationImages.Command command,
            CancellationToken cancellationToken)
        {
            var federations = await federationRepository.GetAll();
            const string extension = ".png";

            logger.LogInformation("[IMPORT FEDERATIONS - START]");

            foreach (var federation in federations)
            {
                var federationImageName = Path.Combine(Path.GetFullPath(webHostEnvironment.WebRootPath),
                    _options.FederationImagesFolderName, $"{federation.Id}{extension}");
                Console.WriteLine(federationImageName);

                try
                {
                    var fileBytes = await File.ReadAllBytesAsync(federationImageName, cancellationToken);
                    var imageBase64 = Convert.ToBase64String(fileBytes);
                    var contentType = MimeTypesMap.GetMimeType(extension);
                    var dataUrl = $"data:{contentType};base64,{imageBase64}";

                    federation.Image = imageService.UpdateEntityImage(federation.Image, dataUrl);
                    await federationRepository.Update(federation);
                }
                catch (Exception)
                {
                    logger.LogInformation(
                        "[IMPORT FEDERATIONS - NO IMAGE] - Federation (Id: {FederationId}, Name: {FederationName}) does not have image to seed",
                        federation.Id, federation.Name);
                }
            }

            logger.LogInformation("[IMPORT FEDERATIONS - END]");

            return Unit.Value;
        }
    }
}