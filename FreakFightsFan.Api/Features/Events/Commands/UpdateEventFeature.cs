using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Commands
{
    public static class UpdateEventFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/events/{id}", async (
                int id,
                UpdateEvent.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Events")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateEvent.Command, Unit>
        {
            private readonly IEventRepository _eventRepository;
            private readonly IClock _clock;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;
            private readonly IMyDictionaryService _dictionaryService;

            public Handler(IEventRepository eventRepository, IClock clock,
                IMyDictionaryItemRepository dictionaryItemRepository, IMyDictionaryService dictionaryService)
            {
                _eventRepository = eventRepository;
                _clock = clock;
                _dictionaryItemRepository = dictionaryItemRepository;
                _dictionaryService = dictionaryService;
            }

            public async Task<Unit> Handle(UpdateEvent.Command command, CancellationToken cancellationToken)
            {
                var myEvent = await _eventRepository.Get(command.Id) ?? throw new MyNotFoundException();

                await ValidateCommand(command);

                myEvent.Modified = _clock.Current();
                myEvent.Name = command.Name;
                myEvent.Date = command.Date.GetValueOrDefault(_clock.Current());
                myEvent.City = (command.CityId is not null) ? await _dictionaryItemRepository.Get(command.CityId.Value) : null;
                myEvent.Hall = (command.HallId is not null) ? await _dictionaryItemRepository.Get(command.HallId.Value) : null;

                await _eventRepository.Update(myEvent);
                return Unit.Value;
            }

            private async Task ValidateCommand(UpdateEvent.Command command)
            {
                if (command.CityId is not null)
                {
                    var isCityValid = await _dictionaryService.ItemIsFromDictionary(command.CityId.Value, DictionaryCode.City);
                    if (!isCityValid)
                        throw new MyValidationException("CityId", $"Dictionary item should be chosen from dictionary with code: {DictionaryCode.City}");
                }

                if (command.HallId is not null)
                {
                    var isHallValid = await _dictionaryService.ItemIsFromDictionary(command.HallId.Value, DictionaryCode.Hall);
                    if (!isHallValid)
                        throw new MyValidationException("HallId", $"Dictionary item should be chosen from dictionary with code: {DictionaryCode.Hall}");
                }
            }
        }
    }
}
