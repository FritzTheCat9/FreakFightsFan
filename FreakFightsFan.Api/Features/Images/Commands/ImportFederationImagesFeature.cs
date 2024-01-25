using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using MediatR;
using HeyRed.Mime;
using Microsoft.Extensions.Options;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Images.Commands;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class ImportFederationImagesFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/import/federations", async (
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new ImportFederationImages.Command();
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<ImportFederationImages.Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IImageService _imageService;
            private readonly IWebHostEnvironment _webHostEnvironment;
            private readonly ImageOptions _options;

            public Handler(IFederationRepository federationRepository, IImageService imageService, IWebHostEnvironment webHostEnvironment, IOptions<ImageOptions> options)
            {
                _federationRepository = federationRepository;
                _imageService = imageService;
                _webHostEnvironment = webHostEnvironment;
                _options = options.Value;
            }

            public async Task<Unit> Handle(ImportFederationImages.Command command, CancellationToken cancellationToken)
            {
                var federations = await _federationRepository.GetAll();
                var extension = ".png";

                //TODO: jak nie ma obrazka to nie można go tu dodać

                foreach (var federation in federations)
                {
                    var federation_image_name = $"{_webHostEnvironment.WebRootPath}\\{_options.FederationImagesFolderName}\\{federation.Id}{extension}";
                    var fileBytes = File.ReadAllBytes(federation_image_name);
                    var imageBase64 = Convert.ToBase64String(fileBytes);
                    var contentType = MimeTypesMap.GetMimeType(extension);
                    var dataUrl = $"data:{contentType};base64,{imageBase64}";

                    federation.Image = _imageService.UpdateEntityImage(federation.Image, dataUrl);
                    await _federationRepository.Update(federation);
                }

                return Unit.Value;
            }
        }
    }
}
