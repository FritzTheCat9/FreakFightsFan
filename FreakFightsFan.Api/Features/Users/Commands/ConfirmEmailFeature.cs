using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Emails;
using FreakFightsFan.Api.Emails.Models;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Commands;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Users.Commands
{
    public static class ConfirmEmailFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/users/confirmEmail", async (ConfirmEmail.Command command,
                        IMediator mediator,
                        CancellationToken cancellationToken)
                    => Results.Ok(await mediator.Send(command, cancellationToken)))
                .WithTags(Tags.Users)
                .AllowAnonymous();
        }

        public class Handler : IRequestHandler<ConfirmEmail.Command, bool>
        {
            private readonly IUserRepository _userRepository;
            private readonly IEmailService _emailService;
            private readonly IStringLocalizer<ApiValidationMessage> _validationLocalizer;
            private readonly IStringLocalizer<EmailTranslation> _emailLocalizer;

            public Handler(
                IUserRepository userRepository,
                IEmailService emailService,
                IStringLocalizer<ApiValidationMessage> validationLocalizer,
                IStringLocalizer<EmailTranslation> emailLocalizer)
            {
                _userRepository = userRepository;
                _emailService = emailService;
                _validationLocalizer = validationLocalizer;
                _emailLocalizer = emailLocalizer;
            }

            public async Task<bool> Handle(
                ConfirmEmail.Command command,
                CancellationToken cancellationToken)
            {
                var user = await _userRepository.GetByEmail(command.Email) ??
                           throw new MyValidationException(nameof(ConfirmEmail.Command.Email),
                               _validationLocalizer[
                                   nameof(ApiValidationMessageString.EmailUserWithGivenEmailDoesNotExist)]);

                if (user.EmailConfirmed)
                    throw new MyValidationException(nameof(ConfirmEmail.Command.Email),
                        _validationLocalizer[nameof(ApiValidationMessageString.EmailAlreadyConfirmed)]);

                var isTokenAssignedToUser = await _userRepository.IsTokenAssignedToUser(user.Email, command.Token);
                if (!isTokenAssignedToUser)
                    throw new MyValidationException(nameof(ConfirmEmail.Command.Token),
                        _validationLocalizer[nameof(ApiValidationMessageString.TokenIsNotAssignedToThisUser)]);

                user.EmailConfirmed = true;
                user.EmailConfirmationToken = null;

                await _userRepository.Update(user);

                await _emailService.SendEmail(user.Email,
                    new EmailConfirmationSuccessfulTemplateModel(_emailLocalizer) { UserName = user.UserName, });

                return isTokenAssignedToUser;
            }
        }
    }
}