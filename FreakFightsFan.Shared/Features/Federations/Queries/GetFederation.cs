using FluentValidation;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Federations.Queries;

public static class GetFederation
{
    public class Query : IRequest<FederationDto>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Query> { }
}