using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class UpdateMyDictionaryFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/myDictionaries/{id}", async (
                int id,
                UpdateMyDictionary.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags(Tags.Dictionaries)
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateMyDictionary.Command, Unit>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;
            private readonly IClock _clock;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(
                IMyDictionaryRepository myDictionaryRepository,
                IClock clock,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                _myDictionaryRepository = myDictionaryRepository;
                _clock = clock;
                _localizer = localizer;
            }

            public async Task<Unit> Handle(
                UpdateMyDictionary.Command command,
                CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(command.Id) ?? throw new MyNotFoundException();

                await ValidateCommand(command, _localizer);

                dictionary.Name = command.Name;
                dictionary.Code = command.Code;
                dictionary.Modified = _clock.Current();

                await _myDictionaryRepository.Update(dictionary);
                return Unit.Value;
            }

            private async Task ValidateCommand(
                UpdateMyDictionary.Command command,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                var codeExists = await _myDictionaryRepository.DictionaryCodeExistsInOtherDictionariesThan(command.Code, command.Id);
                if (codeExists)
                    throw new MyValidationException(nameof(UpdateMyDictionary.Command.Code),
                                                    localizer[nameof(ApiValidationMessageString.CodeMustBeUnique)]);
            }
        }
    }
}
