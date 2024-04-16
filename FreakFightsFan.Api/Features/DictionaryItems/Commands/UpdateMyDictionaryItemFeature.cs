using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

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
                .WithTags(Tags.DictionaryItems)
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateMyDictionaryItem.Command, Unit>
        {
            private readonly IMyDictionaryItemRepository _myDictionaryItemRepository;
            private readonly IClock _clock;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(
                IMyDictionaryItemRepository myDictionaryItemRepository,
                IClock clock,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                _myDictionaryItemRepository = myDictionaryItemRepository;
                _clock = clock;
                _localizer = localizer;
            }

            public async Task<Unit> Handle(
                UpdateMyDictionaryItem.Command command,
                CancellationToken cancellationToken)
            {
                var dictionaryItem = await _myDictionaryItemRepository.Get(command.Id) ?? throw new MyNotFoundException();

                var codeExists = await _myDictionaryItemRepository
                    .DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(command.Code,
                                                                                    dictionaryItem.DictionaryId,
                                                                                    command.Id);
                if (codeExists)
                    throw new MyValidationException(nameof(UpdateMyDictionaryItem.Command.Code),
                                                    _localizer[nameof(ApiValidationMessageString.CodeMustBeUnique)]);

                dictionaryItem.Name = command.Name;
                dictionaryItem.Code = command.Code;
                dictionaryItem.Modified = _clock.Current();

                await _myDictionaryItemRepository.Update(dictionaryItem);
                return Unit.Value;
            }
        }
    }
}
