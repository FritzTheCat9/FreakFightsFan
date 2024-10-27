using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Queries;

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
}