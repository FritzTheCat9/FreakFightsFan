using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands
{
    public static class DeleteMyDictionaryItem
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IMyDictionaryItemRepository _myDictionaryItemRepository;

            public Handler(IMyDictionaryItemRepository myDictionaryItemRepository)
            {
                _myDictionaryItemRepository = myDictionaryItemRepository;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var dictionaryItem = await _myDictionaryItemRepository.Get(command.Id) ?? throw new MyNotFoundException();
                await _myDictionaryItemRepository.Delete(dictionaryItem);
                return Unit.Value;
            }
        }
    }

    public class DeleteMyDictionaryItemEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/myDictionaryItems/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteMyDictionaryItem.Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("MyDictionaryItems");
        }
    }
}
