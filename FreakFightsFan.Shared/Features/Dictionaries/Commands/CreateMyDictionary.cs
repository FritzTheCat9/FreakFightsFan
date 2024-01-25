﻿using FluentValidation;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Shared.Features.Dictionaries.Commands
{
    public static class CreateMyDictionary
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
            public string Code { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty(nameof(x.Name)));

                RuleFor(x => x.Code)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty(nameof(x.Code)))
                    .MaximumLength(30)
                    .Matches("^[A-Z0-9_]+$")
                        .WithMessage("Code can contain only: A-Z, 0-9 and _ characters");
            }
        }
    }
}