using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Fighters.Commands;
using FreakFightsFan.Api.Features.Fighters.Queries;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Fighters.Extensions
{
    public static class FightersExtensions
    {
        public static IEndpointRouteBuilder AddFighterEndpoints(this IEndpointRouteBuilder app)
        {
            CreateFighterFeature.Endpoint(app);
            DeleteFighterFeature.Endpoint(app);
            UpdateFighterFeature.Endpoint(app);
            GetAllFightersFeature.Endpoint(app);
            GetFighterFeature.Endpoint(app);

            return app;
        }

        public static FighterDto ToDto(this Fighter fighter)
        {
            return new()
            {
                Id = fighter.Id,
                Created = fighter.Created,
                Modified = fighter.Modified,
                FirstName = fighter.FirstName,
                LastName = fighter.LastName,
                Nickname = fighter.Nickname,
                InstagramUrl = fighter.InstagramUrl,
                Image = fighter.Image?.ToDto(),
            };
        }

        public static IQueryable<Fighter> FilterFighters(
            this IQueryable<Fighter> fighters,
            GetAllFighters.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                fighters = fighters.Where(x =>
                    x.Nickname.ToLower().Contains(searchTerm)
                    || x.FirstName.ToLower().Contains(searchTerm)
                    || x.LastName.ToLower().Contains(searchTerm));
            }

            return fighters;
        }

        public static IQueryable<Fighter> SortFighters(
            this IQueryable<Fighter> fighters,
            GetAllFighters.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => fighters.OrderBy(GetFighterSortProperty(query)),
                SortOrder.Descending => fighters.OrderByDescending(GetFighterSortProperty(query)),
                SortOrder.None => fighters,
                _ => fighters,
            };
        }

        private static Expression<Func<Fighter, object>> GetFighterSortProperty(GetAllFighters.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "firstname" => fighter => fighter.FirstName,
                "lastname" => fighter => fighter.LastName,
                "nickname" => fighter => fighter.Nickname,
                _ => fighter => fighter.Nickname,
            };
        }
    }
}
