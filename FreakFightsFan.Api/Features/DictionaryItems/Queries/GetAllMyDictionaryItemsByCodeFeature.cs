using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries
{
    public static class GetAllMyDictionaryItemsByCodeFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems/allByCode", async (
                        GetAllMyDictionaryItemsByCode.Query query,
                        IMediator mediator,
                        CancellationToken cancellationToken)
                    => Results.Ok(await mediator.Send(query, cancellationToken)))
                .WithTags(Tags.DictionaryItems)
                .RequireAuthorization(Policy.Admin);
        }

        public class Handler : IRequestHandler<GetAllMyDictionaryItemsByCode.Query, PagedList<MyDictionaryItemDto>>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;
            private readonly ILogger<Handler> _logger;

            public Handler(
                IMyDictionaryRepository myDictionaryRepository,
                ILogger<Handler> logger)
            {
                _myDictionaryRepository = myDictionaryRepository;
                _logger = logger;
            }

            public async Task<PagedList<MyDictionaryItemDto>> Handle(
                GetAllMyDictionaryItemsByCode.Query query,
                CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(query.DictionaryCode);

                if (dictionary is null)
                {
                    _logger.LogError(
                        "[Dictionary Code] Field on frontend tried to access a non-existent dictionary with code: {DictionaryCode}",
                        query.DictionaryCode);

                    var emptyPagedList = PageListExtensions<MyDictionaryItemDto>.CreateEmpty(query.Page,
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