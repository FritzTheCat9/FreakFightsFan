using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands
{
    public static class UpdateMyDictionaryItem
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IMyDictionaryItemRepository _myDictionaryItemRepository;
            private readonly IClock _clock;

            public Handler(IMyDictionaryItemRepository myDictionaryItemRepository, IClock clock)
            {
                _myDictionaryItemRepository = myDictionaryItemRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var dictionaryItem = await _myDictionaryItemRepository.Get(command.Id) ?? throw new MyNotFoundException();

                var nameExists = await _myDictionaryItemRepository.DictionaryItemNameExistsInOtherDictionaryItemsInThisDictionary(command.Name, dictionaryItem.DictionaryId, command.Id);
                if (nameExists)
                    throw new MyValidationException("Name", "'Name' must be unique");

                dictionaryItem.Name = command.Name;
                dictionaryItem.Modified = _clock.Current();

                await _myDictionaryItemRepository.Update(dictionaryItem);
                return Unit.Value;
            }
        }
    }

    public class UpdateMyDictionaryItemEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/myDictionaryItems/{id}", async (
                int id,
                UpdateMyDictionaryItemRequest updateMyDictionaryItemRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new UpdateMyDictionaryItem.Command()
                {
                    Id = id,
                    Name = updateMyDictionaryItemRequest.Name,
                };

                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("MyDictionaryItems");
        }
    }
}
