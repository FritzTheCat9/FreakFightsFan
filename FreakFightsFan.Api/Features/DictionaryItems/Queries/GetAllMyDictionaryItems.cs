using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries
{
    public static class GetAllMyDictionaryItems
    {
        public class Query : IRequest<PagedList<MyDictionaryItemDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }

            public int DictionaryId { get; set; }
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
                var dictionary = await _myDictionaryRepository.Get(query.DictionaryId) ?? throw new MyNotFoundException();
                
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

    public class GetAllMyDictionaryItemsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems/all", async (
                GetAllMyDictionaryItemsRequest getAllMyDictionaryItemsRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetAllMyDictionaryItems.Query()
                {
                    Page = getAllMyDictionaryItemsRequest.Page,
                    PageSize = getAllMyDictionaryItemsRequest.PageSize,
                    SortOrder = getAllMyDictionaryItemsRequest.SortOrder,
                    SortColumn = getAllMyDictionaryItemsRequest.SortColumn,
                    SearchTerm = getAllMyDictionaryItemsRequest.SearchTerm,
                    DictionaryId = getAllMyDictionaryItemsRequest.DictionaryId,
                };

                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags("MyDictionaryItems");
        }
    }
}
