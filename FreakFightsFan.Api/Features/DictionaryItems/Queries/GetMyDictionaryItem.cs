using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Queries
{
    public static class GetMyDictionaryItem
    {
        public class Query : IRequest<MyDictionaryItemDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, MyDictionaryItemDto>
        {
            private readonly IMyDictionaryItemRepository _myDictionaryItemRepository;

            public Handler(IMyDictionaryItemRepository myDictionaryItemRepository)
            {
                _myDictionaryItemRepository = myDictionaryItemRepository;
            }

            public async Task<MyDictionaryItemDto> Handle(Query query, CancellationToken cancellationToken)
            {
                var dictionaryItem = await _myDictionaryItemRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return dictionaryItem.ToDto();
            }
        }
    }

    public class GetMyDictionaryItemEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/myDictionaryItems/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetMyDictionaryItem.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetMyDictionaryItem")
                .WithTags("MyDictionaryItems");
        }
    }
}
