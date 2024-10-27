using FluentValidation;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Queries;

public static class GetMyDictionaryItem
{
    public class Query : IRequest<MyDictionaryItemDto>
    {
        public int Id { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {

    }
}