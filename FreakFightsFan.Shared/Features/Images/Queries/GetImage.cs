using FluentValidation;
using FreakFightsFan.Shared.Features.Images.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Queries;

public static class GetImage
{
    public class Query : IRequest<ImageDto>
    {
        public int Id { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {

    }
}