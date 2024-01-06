using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Requests;
using FreakFightsFan.Shared.Features.Images.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Queries
{
    public static class GetAllImages
    {
        public class Query : IRequest<PagedList<ImageDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<ImageDto>>
        {
            private readonly IImageRepository _imageRepository;

            public Handler(IImageRepository imageRepository)
            {
                _imageRepository = imageRepository;
            }

            public async Task<PagedList<ImageDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var imagesQuery = _imageRepository.AsQueryable();

                imagesQuery = imagesQuery.SortImages(query);

                var imagesPagedList = PageListExtensions<ImageDto>.Create(
                    imagesQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(imagesPagedList);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/images/all", async (
                GetAllImagesRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToGetAllImagesQuery(), cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
