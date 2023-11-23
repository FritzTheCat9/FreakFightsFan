using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Requests;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class UpdateImage
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
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

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IImageRepository _imageRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(IImageRepository imageRepository, IClock clock, IImageService imageService)
            {
                _imageRepository = imageRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(command.Id) ?? throw new MyNotFoundException();

                string name = _imageService.SaveImage(command.ImageBase64);
                _imageService.DeleteImage(image.Name);

                image.Modified = _clock.Current();
                image.Name = name;
                image.Url = _imageService.GetImageUrl(name);

                await _imageRepository.Update(image);
                return Unit.Value;
            }
        }
    }

    public class UpdateImageEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/images/{id}", async (
                int id,
                UpdateImageRequest updateImageRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new UpdateImage.Command()
                    {
                        Id = id,
                        ImageBase64 = updateImageRequest.ImageBase64
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Images");
        }
    }
}
