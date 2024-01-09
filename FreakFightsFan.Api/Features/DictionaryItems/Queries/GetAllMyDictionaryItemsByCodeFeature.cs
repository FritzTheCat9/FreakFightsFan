using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries
{
    public static class GetAllMyDictionaryItemsByCodeFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems/allByCode", async (
                GetAllMyDictionaryItemsByCode.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags("MyDictionaryItems")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<GetAllMyDictionaryItemsByCode.Query, PagedList<MyDictionaryItemDto>>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;

            public Handler(IMyDictionaryRepository myDictionaryRepository)
            {
                _myDictionaryRepository = myDictionaryRepository;
            }

            public async Task<PagedList<MyDictionaryItemDto>> Handle(GetAllMyDictionaryItemsByCode.Query query, CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(query.DictionaryCode);

                if (dictionary is null)
                {
                    // log to file - field on frontend tried to access a non-existent dictionary

                    var emptyPagedList = PageListExtensions<MyDictionaryItemDto>.CreateEmpty(
                        query.Page,
                        query.PageSize);

                    return emptyPagedList;
                }

                var dictionaryItemsQuery = dictionary.DictionaryItems.AsQueryable();

                dictionaryItemsQuery = dictionaryItemsQuery.FilterMyDictionaryItems(query);
                dictionaryItemsQuery = dictionaryItemsQuery.SortMyDictionaryItems(query);

                var dictionaryItemsPagedList = PageListExtensions<MyDictionaryItemDto>.Create(
                    dictionaryItemsQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return dictionaryItemsPagedList;
            }
        }
    }
}
