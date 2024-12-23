﻿using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Queries;

public static class GetAllMyDictionariesFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/myDictionaries/all", async (
                GetAllMyDictionaries.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.Dictionaries)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IMyDictionaryRepository myDictionaryRepository)
        : IRequestHandler<GetAllMyDictionaries.Query, PagedList<MyDictionaryDto>>
    {
        public async Task<PagedList<MyDictionaryDto>> Handle(
            GetAllMyDictionaries.Query query,
            CancellationToken cancellationToken)
        {
            var dictionariesQuery = myDictionaryRepository.AsQueryable();

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