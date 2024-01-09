using FluentValidation;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Queries
{
    public class GetUser
    {
        public class Query : IRequest<UserDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
