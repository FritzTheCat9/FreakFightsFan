using FluentValidation;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Dictionaries.Queries;

public static class GetMyDictionary
{
    public class Query : IRequest<MyDictionaryDto>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Query> { }
}