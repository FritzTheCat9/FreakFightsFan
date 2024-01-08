using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Queries
{
    public static class GetMyDictionaryFeature
    {
        public class Handler : IRequestHandler<GetMyDictionary.Query, MyDictionaryDto>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;

            public Handler(IMyDictionaryRepository myDictionaryRepository)
            {
                _myDictionaryRepository = myDictionaryRepository;
            }

            public async Task<MyDictionaryDto> Handle(GetMyDictionary.Query query, CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return dictionary.ToDto();
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/myDictionaries/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetMyDictionary.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetMyDictionary")
                .WithTags("MyDictionaries")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
