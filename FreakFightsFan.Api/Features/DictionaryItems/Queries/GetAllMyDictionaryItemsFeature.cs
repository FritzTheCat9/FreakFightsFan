using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries;

public static class GetAllMyDictionaryItemsFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/myDictionaryItems/all", async (
                GetAllMyDictionaryItems.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.DictionaryItems)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IMyDictionaryRepository myDictionaryRepository)
        : IRequestHandler<GetAllMyDictionaryItems.Query, PagedList<MyDictionaryItemDto>>
    {
        public async Task<PagedList<MyDictionaryItemDto>> Handle(
            GetAllMyDictionaryItems.Query query,
            CancellationToken cancellationToken)
        {
            var dictionary = await myDictionaryRepository.Get(query.DictionaryId) ??
                             throw new MyNotFoundException();

            var dictionaryItemsQuery = dictionary.DictionaryItems.AsQueryable();

            dictionaryItemsQuery = dictionaryItemsQuery.FilterMyDictionaryItems(query);
            dictionaryItemsQuery = dictionaryItemsQuery.SortMyDictionaryItems(query);

            var dictionaryItemsPagedList =
                PageListExtensions<MyDictionaryItemDto>.Create(
                    dictionaryItemsQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

            return dictionaryItemsPagedList;
        }
    }
}