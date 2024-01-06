using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries
{
    public static class GetAllMyDictionaryItemsByCode
    {
        public class Query : IRequest<PagedList<MyDictionaryItemDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }

            public string DictionaryCode { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<MyDictionaryItemDto>>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;

            public Handler(IMyDictionaryRepository myDictionaryRepository)
            {
                _myDictionaryRepository = myDictionaryRepository;
            }

            public async Task<PagedList<MyDictionaryItemDto>> Handle(Query query, CancellationToken cancellationToken)
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

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems/allByCode", async (
                GetAllMyDictionaryItemsByCodeRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToGetAllMyDictionaryItemsByCodeQuery(), cancellationToken));
            })
                .WithTags("MyDictionaryItems")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
