﻿using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Federations.Commands
{
    public class DeleteFederation
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }
    }
}
