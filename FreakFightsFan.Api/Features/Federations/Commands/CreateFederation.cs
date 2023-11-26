using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Federations.Requests;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class CreateFederation
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
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

                RuleFor(x => x.Name)
                    .NotEmpty();

                When(x => !string.IsNullOrEmpty(x.ImageBase64), () =>
                {
                    RuleFor(x => x.ImageBase64)
                        .NotEmpty()
                        .Must(x => ImageHelpers.HaveValidSize(x, _options.MaxFileSize))
                            .WithMessage($"The maximum file size is {_options.MaxFileSize} bytes")
                        .Must(x => ImageHelpers.HaveValidFileType(x, _options.AllowedFileTypes))
                            .WithMessage($"Allowed image types: {_allowedFileTypesString}");
                });
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(IFederationRepository federationRepository, IClock clock, IImageService imageService)
            {
                _federationRepository = federationRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = new Federation
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Image = _imageService.CreateEntityImage(command.ImageBase64),
                };

                return await _federationRepository.Create(federation);
            }
        }
    }

    public class CreateFederationEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/federations", async (
                CreateFederationRequest createFederationRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateFederation.Command()
                    {
                        Name = createFederationRequest.Name,
                        ImageBase64 = createFederationRequest.ImageBase64,
                    };

                    int federationId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFederation", new { id = federationId });
                })
                .WithTags("Federations");
        }
    }
}
