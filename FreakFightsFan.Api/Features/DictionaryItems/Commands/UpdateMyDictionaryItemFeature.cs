using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands
{
    public static class UpdateMyDictionaryItemFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/myDictionaryItems/{id}", async (
                int id,
                UpdateMyDictionaryItem.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("MyDictionaryItems")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateMyDictionaryItem.Command, Unit>
        {
            private readonly IMyDictionaryItemRepository _myDictionaryItemRepository;
            private readonly IClock _clock;

            public Handler(IMyDictionaryItemRepository myDictionaryItemRepository, IClock clock)
            {
                _myDictionaryItemRepository = myDictionaryItemRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(UpdateMyDictionaryItem.Command command, CancellationToken cancellationToken)
            {
                var dictionaryItem = await _myDictionaryItemRepository.Get(command.Id) ?? throw new MyNotFoundException();

                var codeExists = await _myDictionaryItemRepository.DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(command.Code, dictionaryItem.DictionaryId, command.Id);
                if (codeExists)
                    throw new MyValidationException("Code", "'Code' must be unique");

                dictionaryItem.Name = command.Name;
                dictionaryItem.Code = command.Code;
                dictionaryItem.Modified = _clock.Current();

                await _myDictionaryItemRepository.Update(dictionaryItem);
                return Unit.Value;
            }
        }
    }
}
