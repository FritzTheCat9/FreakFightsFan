using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class UpdateFighter
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Nickname { get; set; }
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

                RuleFor(x => x.FirstName)
                    .NotEmpty();

                RuleFor(x => x.LastName)
                    .NotEmpty();

                RuleFor(x => x.Nickname)
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
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(IFighterRepository fighterRepository, IClock clock, IImageService imageService)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();
                fighter.FirstName = command.FirstName;
                fighter.LastName = command.LastName;
                fighter.Nickname = command.Nickname;
                fighter.Modified = _clock.Current();
                fighter.Image = _imageService.UpdateEntityImage(fighter.Image, command.ImageBase64);

                await _fighterRepository.Update(fighter);
                return Unit.Value;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fighters/{id}", async (
                int id,
                UpdateFighterRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToUpdateFighterCommand(id), cancellationToken));
            })
                .WithTags("Fighters");

            return app;
        }
    }
}