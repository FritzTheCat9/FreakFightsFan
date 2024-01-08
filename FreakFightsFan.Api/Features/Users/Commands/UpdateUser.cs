using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Auth;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Requests;
using MediatR;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Features.Users.Commands;

public static class UpdateUser
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
        private readonly IUserRepository _userRepository;
        private readonly IClock _clock;
        private readonly IImageService _imageService;
        private readonly IAuthService _authService;

        public Handler(IUserRepository userRepository, IClock clock, IImageService imageService, IAuthService authService)
        {
            _userRepository = userRepository;
            _clock = clock;
            _imageService = imageService;
            _authService = authService;
        }

        public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(command.Id) ?? throw new MyNotFoundException();

            // TODO: dodać to ok ok 

            // validacja czy my to user bo swoje zdjęcie można zmieniać (ale admin też może i super admin)
            // albo czy user to identity user albo czy mamy role admin lub super admin

            //var validRole = _authService.IsInAnyRole(Role.Admin, Role.SuperAdmin);
            //var isProfileOwner = _authService.User.Identity.id ???

            //user.Modified = _clock.Current();
            //user.Image = _imageService.UpdateEntityImage(user.Image, command.ImageBase64);

            await _userRepository.Update(user);
            return Unit.Value;
        }
    }

    public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/users/{id}", async (
            int id,
            UpdateUserRequest request,
            IMediator mediator,
            CancellationToken cancellationToken) =>
        {
            return Results.Ok(await mediator.Send(request.ToUpdateUserCommand(id), cancellationToken));
        })
            .WithTags("Users")
            .RequireAuthorization(Policy.User);

        return app;
    }
}