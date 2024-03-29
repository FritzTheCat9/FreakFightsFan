﻿using FluentValidation;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Federations.Queries
{
    public class GetFederation
    {
        public class Query : IRequest<FederationDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
