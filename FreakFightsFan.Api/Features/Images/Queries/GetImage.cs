using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Queries
{
    public static class GetImage
    {
        public class Query : IRequest<ImageDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, ImageDto>
        {
            private readonly IImageRepository _imageRepository;

            public Handler(IImageRepository imageRepository)
            {
                _imageRepository = imageRepository;
            }

            public async Task<ImageDto> Handle(Query query, CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return image.ToDto();
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetImage")
                .WithTags("Images");

            return app;
        }
    }
}
