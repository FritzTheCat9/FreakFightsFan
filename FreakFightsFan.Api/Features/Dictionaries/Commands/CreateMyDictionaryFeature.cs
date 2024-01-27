using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using MediatR;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Api.Localization;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class CreateMyDictionaryFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaries", async (
                CreateMyDictionary.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int dictionaryId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionary", new { id = dictionaryId });
            })
                .WithTags("MyDictionaries")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateMyDictionary.Command, int>
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

            public async Task<int> Handle(
                CreateMyDictionary.Command command,
                CancellationToken cancellationToken)
            {
                await ValidateCommand(command, _localizer);

                var dictionary = new MyDictionary
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Code = command.Code,
                };

                return await _myDictionaryRepository.Create(dictionary);
            }

            private async Task ValidateCommand(
                CreateMyDictionary.Command command,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                var codeExists = await _myDictionaryRepository.DictionaryCodeExists(command.Code);
                if (codeExists)
                    throw new MyValidationException(nameof(CreateMyDictionary.Command.Code),
                                                    localizer[nameof(ApiValidationMessageString.CodeMustBeUnique)]);
            }
        }
    }
}
