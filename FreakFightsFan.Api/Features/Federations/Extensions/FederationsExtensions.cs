using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Federations.Commands;
using FreakFightsFan.Api.Features.Federations.Queries;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Federations.Extensions
{
    public static class FederationsExtensions
    {
        public static IEndpointRouteBuilder AddFederationEndpoints(this IEndpointRouteBuilder app)
        {
            CreateFederationFeature.Endpoint(app);
            DeleteFederationFeature.Endpoint(app);
            UpdateFederationFeature.Endpoint(app);
            GetAllFederationsFeature.Endpoint(app);
            GetFederationFeature.Endpoint(app);

            return app;
        }

        public static FederationDto ToDto(this Federation federation)
        {
            return new()
            {
                Id = federation.Id,
                Created = federation.Created,
                Modified = federation.Modified,
                Name = federation.Name, 
                Image = federation.Image?.ToDto(),
            };
        }

        public static IQueryable<Federation> FilterFederations(this IQueryable<Federation> federations, GetAllFederations.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                federations = federations.Where(x =>
                    x.Name.ToLower().Contains(searchTerm));
            }
            return federations;
        }

        public static IQueryable<Federation> SortFederations(this IQueryable<Federation> federations, GetAllFederations.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => federations.OrderBy(GetFederationSortProperty(query)),
                SortOrder.Descending => federations.OrderByDescending(GetFederationSortProperty(query)),
                SortOrder.None => federations,
                _ => federations,
            };
        }

        private static Expression<Func<Federation, object>> GetFederationSortProperty(GetAllFederations.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => federation => federation.Name,
                _ => federation => federation.Name,
            };
        }
    }
}
