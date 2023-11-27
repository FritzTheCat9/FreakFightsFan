using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Fights.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Fights.Extensions
{
    public static class FightsExtensions
    {
        public static FightDto ToDto(this Fight fight)
        {
            return new FightDto
            {
                Id = fight.Id,
                Created = fight.Created,
                Modified = fight.Modified,
                Name = fight.Name,
            };
        }

        public static IQueryable<Fight> FilterFights(this IQueryable<Fight> fights, GetAllFights.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                fights = fights.Where(x =>
                    x.Name.ToLower().Contains(searchTerm));
            }
            return fights;
        }

        public static IQueryable<Fight> SortFights(this IQueryable<Fight> fights, GetAllFights.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => fights.OrderBy(GetFightSortProperty(query)),
                SortOrder.Descending => fights.OrderByDescending(GetFightSortProperty(query)),
                SortOrder.None => fights,
                _ => fights,
            };
        }

        private static Expression<Func<Fight, object>> GetFightSortProperty(GetAllFights.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => fight => fight.Name,
                _ => fight => fight.Name,
            };
        }
    }
}
