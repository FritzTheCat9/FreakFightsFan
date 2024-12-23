﻿using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands;

public static class DeleteMyDictionaryFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/api/myDictionaries/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteMyDictionary.Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Dictionaries)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IMyDictionaryRepository myDictionaryRepository)
        : IRequestHandler<DeleteMyDictionary.Command, Unit>
    {
        public async Task<Unit> Handle(
            DeleteMyDictionary.Command command,
            CancellationToken cancellationToken)
        {
            var dictionary =
                await myDictionaryRepository.Get(command.Id) ?? throw new MyNotFoundException();
            await myDictionaryRepository.Delete(dictionary);
            return Unit.Value;
        }
    }
}