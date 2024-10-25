﻿using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Users.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Queries;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Users.Queries
{
    public static class GetUserFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/users/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetUser.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetUser")
                .WithTags(Tags.Users)
                .AllowAnonymous();
        }

        public class Handler : IRequestHandler<GetUser.Query, UserDto>
        {
            private readonly IUserRepository _userRepository;

            public Handler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<UserDto> Handle(
                GetUser.Query query,
                CancellationToken cancellationToken)
            {
                var user = await _userRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return user.ToDto();
            }
        }
    }
}
