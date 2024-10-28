using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands;

public static class DeleteMyDictionaryItemFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/api/myDictionaryItems/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteMyDictionaryItem.Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.DictionaryItems)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IMyDictionaryItemRepository myDictionaryItemRepository)
        : IRequestHandler<DeleteMyDictionaryItem.Command, Unit>
    {
        public async Task<Unit> Handle(
            DeleteMyDictionaryItem.Command command,
            CancellationToken cancellationToken)
        {
            var dictionaryItem = await myDictionaryItemRepository.Get(command.Id) ??
                                 throw new MyNotFoundException();

            await myDictionaryItemRepository.Delete(dictionaryItem);
            return Unit.Value;
        }
    }
}