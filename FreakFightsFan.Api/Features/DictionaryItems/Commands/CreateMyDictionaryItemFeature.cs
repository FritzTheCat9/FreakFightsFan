﻿using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands
{
    public static class CreateMyDictionaryItemFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaryItems", async (
                CreateMyDictionaryItem.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int dictionaryItemId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionaryItem", new { id = dictionaryItemId });
            })
                .WithTags("MyDictionaryItems")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateMyDictionaryItem.Command, int>
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

            public async Task<int> Handle(CreateMyDictionaryItem.Command command, CancellationToken cancellationToken)
            {
                await ValidateCommand(command);

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

            private async Task ValidateCommand(CreateMyDictionaryItem.Command command)
            {
                var dictionary = await _myDictionaryRepository.Get(command.DictionaryId) ?? throw new MyNotFoundException();

                var codeExists = await _myDictionaryItemRepository.DictionaryItemCodeExists(command.Code, command.DictionaryId);
                if (codeExists)
                    throw new MyValidationException(nameof(CreateMyDictionaryItem.Command.Code), $"{nameof(CreateMyDictionaryItem.Command.Code)} must be unique");
            }
        }
    }
}
