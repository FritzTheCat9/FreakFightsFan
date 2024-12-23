﻿using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.DictionaryItems.Commands;

public static class CreateMyDictionaryItemFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/myDictionaryItems", async (
                CreateMyDictionaryItem.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var dictionaryItemId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionaryItem", new { id = dictionaryItemId });
            })
            .WithTags(Tags.DictionaryItems)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IMyDictionaryItemRepository myDictionaryItemRepository,
        IMyDictionaryRepository myDictionaryRepository,
        IClock clock,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<CreateMyDictionaryItem.Command, int>
    {
        public async Task<int> Handle(
            CreateMyDictionaryItem.Command command,
            CancellationToken cancellationToken)
        {
            await ValidateCommand(command, localizer);

            var dictionaryItem = new MyDictionaryItem
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                Name = command.Name,
                Code = command.Code,
                DictionaryId = command.DictionaryId
            };

            return await myDictionaryItemRepository.Create(dictionaryItem);
        }

        private async Task ValidateCommand(
            CreateMyDictionaryItem.Command command,
            IStringLocalizer<ApiValidationMessage> localizer)
        {
            var dictionary = await myDictionaryRepository.Get(command.DictionaryId) ??
                             throw new MyNotFoundException();

            var codeExists =
                await myDictionaryItemRepository.DictionaryItemCodeExists(command.Code, command.DictionaryId);
            if (codeExists)
            {
                throw new MyValidationException(nameof(CreateMyDictionaryItem.Command.Code),
                    localizer[nameof(ApiValidationMessageString.CodeMustBeUnique)]);
            }
        }
    }
}