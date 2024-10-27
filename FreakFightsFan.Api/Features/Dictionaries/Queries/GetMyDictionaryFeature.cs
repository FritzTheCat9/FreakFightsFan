using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Queries;

public static class GetMyDictionaryFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/myDictionaries/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetMyDictionary.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetMyDictionary")
            .WithTags(Tags.Dictionaries)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IMyDictionaryRepository myDictionaryRepository)
        : IRequestHandler<GetMyDictionary.Query, MyDictionaryDto>
    {
        public async Task<MyDictionaryDto> Handle(
            GetMyDictionary.Query query,
            CancellationToken cancellationToken)
        {
            var dictionary = await myDictionaryRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return dictionary.ToDto();
        }
    }
}