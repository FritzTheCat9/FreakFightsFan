using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Services;
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
            private readonly IImageService _imageService;

            public Handler(IImageRepository imageRepository, IClock clock, IImageService imageService)
            {
                _imageRepository = imageRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                string name = _imageService.SaveImage(command.ImageBase64);

                var image = new Image
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = name,
                    Url = _imageService.GetImageUrl(name)
                };

                return await _imageRepository.Create(image);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/images", async (
                CreateImageRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int imageId = await mediator.Send(request.ToCreateImageCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetImage", new { id = imageId });
            })
                .WithTags("Images");

            return app;
        }
    }
}
