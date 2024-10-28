using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries;

public static class GetMyDictionaryItemFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/myDictionaryItems/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetMyDictionaryItem.Query { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetMyDictionaryItem")
            .WithTags(Tags.DictionaryItems)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IMyDictionaryItemRepository myDictionaryItemRepository)
        : IRequestHandler<GetMyDictionaryItem.Query, MyDictionaryItemDto>
    {
        public async Task<MyDictionaryItemDto> Handle(
            GetMyDictionaryItem.Query query,
            CancellationToken cancellationToken)
        {
            var dictionaryItem =
                await myDictionaryItemRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return dictionaryItem.ToDto();
        }
    }
}