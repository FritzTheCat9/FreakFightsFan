using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
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
            public int DictionaryId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
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

                var nameExists = await _myDictionaryItemRepository.DictionaryItemNameExists(command.Name, command.DictionaryId);
                if (nameExists)
                    throw new MyValidationException("Name", "'Name' must be unique");

                var dictionaryItem = new MyDictionaryItem
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    DictionaryId = command.DictionaryId,
                };

                return await _myDictionaryItemRepository.Create(dictionaryItem);
            }
        }
    }

    public class CreateMyDictionaryItemEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems", async (
                CreateMyDictionaryItemRequest createMyDictionaryItemRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new CreateMyDictionaryItem.Command()
                {
                    Name = createMyDictionaryItemRequest.Name, 
                    DictionaryId = createMyDictionaryItemRequest.DictionaryId,
                };

                int dictionaryItemId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionaryItem", new { id = dictionaryItemId });
            })
                .WithTags("MyDictionaryItems");
        }
    }
}
