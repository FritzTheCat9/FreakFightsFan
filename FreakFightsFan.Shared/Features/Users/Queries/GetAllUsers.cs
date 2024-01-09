﻿using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Queries
{
    public class GetAllUsers
    {
        public class Query : IRequest<PagedList<UserDto>>, IPagedQuery, ISortedQuery
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
    }
}
