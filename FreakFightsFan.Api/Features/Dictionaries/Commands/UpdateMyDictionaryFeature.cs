using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class UpdateMyDictionaryFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/myDictionaries/{id}", async (
                int id,
                UpdateMyDictionary.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("MyDictionaries")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateMyDictionary.Command, Unit>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;
            private readonly IClock _clock;

            public Handler(IMyDictionaryRepository myDictionaryRepository, IClock clock)
            {
                _myDictionaryRepository = myDictionaryRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(UpdateMyDictionary.Command command, CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(command.Id) ?? throw new MyNotFoundException();

                await ValidateCommand(command);

                dictionary.Name = command.Name;
                dictionary.Code = command.Code;
                dictionary.Modified = _clock.Current();

                await _myDictionaryRepository.Update(dictionary);
                return Unit.Value;
            }

            private async Task ValidateCommand(UpdateMyDictionary.Command command)
            {
                var codeExists = await _myDictionaryRepository.DictionaryCodeExistsInOtherDictionariesThan(command.Code, command.Id);
                if (codeExists)
                    throw new MyValidationException(nameof(UpdateMyDictionary.Command.Code), $"{nameof(UpdateMyDictionary.Command.Code)} must be unique");
            }
        }
    }
}
