﻿using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Queries;

public static class GetAllFights
{
    public class Query : IRequest<PagedList<FightDto>>, IPagedQuery
    {
        public int EventId { get; init; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }

    public class Validator : AbstractValidator<Query> { }
}