using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using MediatR;
using HeyRed.Mime;
using Microsoft.Extensions.Options;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Features.Users.Helpers;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class ImportFederationImages
    {
        public class ImportFederationImagesCommand : IRequest<Unit>
        {

        }

        public class Validator : AbstractValidator<ImportFederationImagesCommand>
        {
            public Validator()
            {

            }
        }

        public class Handler : IRequestHandler<ImportFederationImagesCommand, Unit>
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

            public async Task<Unit> Handle(ImportFederationImagesCommand command, CancellationToken cancellationToken)
            {
                var federations = await _federationRepository.GetAll();
                var extension = ".png";

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

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/import/federations", async (
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new ImportFederationImagesCommand();
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
