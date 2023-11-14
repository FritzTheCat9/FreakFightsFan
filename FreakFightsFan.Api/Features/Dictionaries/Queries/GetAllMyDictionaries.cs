using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Queries
{
    public static class GetAllMyDictionaries
    {
        public class Query : IRequest<PagedList<MyDictionaryDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<MyDictionaryDto>>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;

            public Handler(IMyDictionaryRepository myDictionaryRepository)
            {
                _myDictionaryRepository = myDictionaryRepository;
            }

            public async Task<PagedList<MyDictionaryDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var dictionariesQuery = _myDictionaryRepository.AsQueryable();

                dictionariesQuery = dictionariesQuery.FilterMyDictionaries(query);
                dictionariesQuery = dictionariesQuery.SortMyDictionaries(query);

                var dictionariesPagedList = PageListExtensions<MyDictionaryDto>.Create(
                    dictionariesQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(dictionariesPagedList);
            }
        }
    }

    public class GetAllMyDictionariesEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaries/all", async (
                GetAllMyDictionariesRequest getAllMyDictionariesRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetAllMyDictionaries.Query()
                {
                    Page = getAllMyDictionariesRequest.Page,
                    PageSize = getAllMyDictionariesRequest.PageSize,
                    SortOrder = getAllMyDictionariesRequest.SortOrder,
                    SortColumn = getAllMyDictionariesRequest.SortColumn,
                    SearchTerm = getAllMyDictionariesRequest.SearchTerm,
                };

                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags("MyDictionaries");
        }
    }
}
