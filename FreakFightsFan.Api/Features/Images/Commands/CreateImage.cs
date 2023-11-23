using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Features.Images.Requests;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class CreateImage
    {
        public class Command : IRequest<int>
        {
            public string ImageBase64 { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            private readonly ImageOptions _options;
            private readonly string _allowedFileTypesString;

            public Validator(IOptions<ImageOptions> options)
            {
                _options = options.Value;
                _allowedFileTypesString = ImageHelpers.MakeAllowedFileTypesString(_options.AllowedFileTypes);

                RuleFor(x => x.ImageBase64)
                    .NotEmpty()
                    .Must(x => ImageHelpers.HaveValidSize(x, _options.MaxFileSize))
                        .WithMessage($"The maximum file size is {_options.MaxFileSize} bytes")
                    .Must(x => ImageHelpers.HaveValidFileType(x, _options.AllowedFileTypes))
                        .WithMessage($"Allowed image types: {_allowedFileTypesString}");
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IImageRepository _imageRepository;
            private readonly IClock _clock;

            public Handler(IImageRepository imageRepository, IClock clock)
            {
                _imageRepository = imageRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var image = new Image
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Data = ImageHelpers.GetImageData(command.ImageBase64),
                    ContentType = ImageHelpers.GetImageContentType(command.ImageBase64)
                };

                return await _imageRepository.Create(image);
            }
        }
    }

    public class CreateImageEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/images", async (
                CreateImageRequest createImageRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateImage.Command()
                    {
                        ImageBase64 = createImageRequest.ImageBase64,
                    };

                    int imageId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetImage", new { id = imageId });
                })
                .WithTags("Images");
        }
    }
}
