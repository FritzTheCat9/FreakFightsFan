using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Fights.Commands;
using FreakFightsFan.Api.Features.Fights.Queries;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Features.Fights.Requests;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Api.Features.Fights.Extensions
{
    public static class FightsExtensions
    {
        public static IEndpointRouteBuilder AddFightEndpoints(this IEndpointRouteBuilder app)
        {
            CreateFight.Endpoint(app);
            DeleteFight.Endpoint(app);
            UpdateFight.Endpoint(app);
            GetAllFights.Endpoint(app);
            GetFight.Endpoint(app);

            return app;
        }

        public static FightDto ToDto(this Fight fight)
        {
            return new FightDto
            {
                Id = fight.Id,
                Created = fight.Created,
                Modified = fight.Modified,
                EventId = fight.EventId,
                Teams = fight.Teams.Select(x => x.ToDto()).ToList()
            };
        }

        public static CreateFight.Command ToCreateFightCommand(this CreateFightRequest request)
        {
            return new CreateFight.Command
            {
                EventId = request.EventId,
                Teams = request.Teams,
            };
        }

        public static UpdateFight.Command ToUpdateFightCommand(this UpdateFightRequest request, int id)
        {
            return new UpdateFight.Command
            {
                Id = id,
                Teams = request.Teams,
            };
        }

        public static GetAllFights.Query ToGetAllFightsQuery(this GetAllFightsRequest request)
        {
            return new GetAllFights.Query
            {
                Page = request.Page,
                PageSize = request.PageSize,
                EventId = request.EventId
            };
        }
    }
}
