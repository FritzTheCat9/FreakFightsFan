using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands
{
    public static class CreateMyDictionaryItem
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public int DictionaryId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();

                RuleFor(x => x.Code)
                    .NotEmpty()
                    .MaximumLength(30)
                    .Matches("^[A-Z0-9_]+$")
                        .WithMessage("Code can contain only: A-Z, 0-9 and _ characters");
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IMyDictionaryItemRepository _myDictionaryItemRepository;
            private readonly IMyDictionaryRepository _myDictionaryRepository;
            private readonly IClock _clock;

            public Handler(IMyDictionaryItemRepository myDictionaryItemRepository, IMyDictionaryRepository myDictionaryRepository, IClock clock)
            {
                _myDictionaryItemRepository = myDictionaryItemRepository;
                _myDictionaryRepository = myDictionaryRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(command.DictionaryId) ?? throw new MyNotFoundException();

                var codeExists = await _myDictionaryItemRepository.DictionaryItemCodeExists(command.Code, command.DictionaryId);
                if (codeExists)
                    throw new MyValidationException("Code", "'Code' must be unique");

                var dictionaryItem = new MyDictionaryItem
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Code = command.Code,
                    DictionaryId = command.DictionaryId,
                };

                return await _myDictionaryItemRepository.Create(dictionaryItem);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems", async (
                CreateMyDictionaryItemRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int dictionaryItemId = await mediator.Send(request.ToCreateMyDictionaryItemCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionaryItem", new { id = dictionaryItemId });
            })
                .WithTags("MyDictionaryItems");

            return app;
        }
    }
}
