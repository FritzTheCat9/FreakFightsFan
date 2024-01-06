using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Requests;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class UpdateFederation
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
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

        public class Handler : IRequestHandler<Command, Unit>
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

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.Id) ?? throw new MyNotFoundException();

                federation.Modified = _clock.Current();
                federation.Name = command.Name;
                federation.Image = _imageService.UpdateEntityImage(federation.Image, command.ImageBase64);

                await _federationRepository.Update(federation);
                return Unit.Value;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/federations/{id}", async (
                int id,
                UpdateFederationRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToUpdateFederationCommand(id), cancellationToken));
            })
                .WithTags("Federations")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
