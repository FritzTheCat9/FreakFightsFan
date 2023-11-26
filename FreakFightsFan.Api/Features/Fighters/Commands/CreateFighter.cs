using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class CreateFighter
    {
        public class Command : IRequest<int>
        {
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

        public class Handler : IRequestHandler<Command, int>
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

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var fighter = new Fighter
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Nickname = command.Nickname,
                    Image = _imageService.CreateEntityImage(command.ImageBase64),
                };

                return await _fighterRepository.Create(fighter);
            }
        }
    }

    public class CreateFighterEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fighters", async (
                CreateFighterRequest createFighterRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateFighter.Command()
                    {
                        FirstName = createFighterRequest.FirstName,
                        LastName = createFighterRequest.LastName,
                        Nickname = createFighterRequest.Nickname,
                        ImageBase64 = createFighterRequest.ImageBase64,
                    };

                    int fighterId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFighter", new { id = fighterId });
                })
                .WithTags("Fighters");
        }
    }
}
