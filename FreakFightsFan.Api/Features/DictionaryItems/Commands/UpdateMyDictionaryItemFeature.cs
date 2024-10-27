using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands;

public static class UpdateMyDictionaryItemFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/myDictionaryItems/{id:int}", async (
                int id,
                UpdateMyDictionaryItem.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.DictionaryItems)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IMyDictionaryItemRepository myDictionaryItemRepository,
        IClock clock,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<UpdateMyDictionaryItem.Command, Unit>
    {
        public async Task<Unit> Handle(
            UpdateMyDictionaryItem.Command command,
            CancellationToken cancellationToken)
        {
            var dictionaryItem = await myDictionaryItemRepository.Get(command.Id) ??
                                 throw new MyNotFoundException();

            var codeExists = await myDictionaryItemRepository
                .DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(command.Code,
                    dictionaryItem.DictionaryId,
                    command.Id);
            if (codeExists)
            {
                throw new MyValidationException(nameof(UpdateMyDictionaryItem.Command.Code),
                    localizer[nameof(ApiValidationMessageString.CodeMustBeUnique)]);
            }

            dictionaryItem.Name = command.Name;
            dictionaryItem.Code = command.Code;
            dictionaryItem.Modified = clock.Current();

            await myDictionaryItemRepository.Update(dictionaryItem);
            return Unit.Value;
        }
    }
}