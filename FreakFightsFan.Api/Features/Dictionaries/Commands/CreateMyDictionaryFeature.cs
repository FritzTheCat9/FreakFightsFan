using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands;

public static class CreateMyDictionaryFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/myDictionaries", async (
                CreateMyDictionary.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var dictionaryId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionary", new { id = dictionaryId });
            })
            .WithTags(Tags.Dictionaries)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IMyDictionaryRepository myDictionaryRepository,
        IClock clock,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<CreateMyDictionary.Command, int>
    {
        public async Task<int> Handle(
            CreateMyDictionary.Command command,
            CancellationToken cancellationToken)
        {
            await ValidateCommand(command, localizer);

            var dictionary = new MyDictionary
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                Name = command.Name,
                Code = command.Code,
            };

            return await myDictionaryRepository.Create(dictionary);
        }

        private async Task ValidateCommand(
            CreateMyDictionary.Command command,
            IStringLocalizer<ApiValidationMessage> localizer)
        {
            var codeExists = await myDictionaryRepository.DictionaryCodeExists(command.Code);
            if (codeExists)
            {
                throw new MyValidationException(nameof(CreateMyDictionary.Command.Code),
                    localizer[nameof(ApiValidationMessageString.CodeMustBeUnique)]);
            }
        }
    }
}