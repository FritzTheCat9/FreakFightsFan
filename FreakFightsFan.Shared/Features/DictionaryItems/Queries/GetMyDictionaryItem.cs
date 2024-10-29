using FluentValidation;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Queries;

public static class GetMyDictionaryItem
{
    public class Query : IRequest<MyDictionaryItemDto>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Query> { }
}