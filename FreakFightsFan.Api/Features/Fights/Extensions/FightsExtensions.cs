using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Features.Events.Extensions;
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
            MoveFight.Endpoint(app);
            UpdateFight.Endpoint(app);
            GetAllFights.Endpoint(app);
            GetFight.Endpoint(app);
            GetFighterProfile.Endpoint(app);

            return app;
        }

        public static FightDto ToDto(this Fight fight)
        {
            return new()
            {
                Id = fight.Id,
                Created = fight.Created,
                Modified = fight.Modified,
                OrderNumber = fight.OrderNumber,
                VideoUrl = fight.VideoUrl,
                EventId = fight.EventId,
                Event = fight.Event.ToDto(),
                Teams = fight.Teams.Select(x => x.ToDto()).ToList(),
                Type = fight.Type?.ToDto(),
            };
        }

        public static CreateFight.Command ToCreateFightCommand(this CreateFightRequest request)
        {
            return new()
            {
                EventId = request.EventId,
                Teams = request.Teams,
                VideoUrl = request.VideoUrl,
                TypeId = request.TypeId,
            };
        }

        public static MoveFight.Command ToMoveFightCommand(this MoveFightRequest request, int id)
        {
            return new()
            {
                Id = id, 
                Direction = request.Direction,
            };
        }

        public static UpdateFight.Command ToUpdateFightCommand(this UpdateFightRequest request, int id)
        {
            return new()
            {
                Id = id,
                Teams = request.Teams,
                VideoUrl = request.VideoUrl,
                TypeId = request.TypeId,
            };
        }

        public static GetAllFights.Query ToGetAllFightsQuery(this GetAllFightsRequest request)
        {
            return new()
            {
                Page = request.Page,
                PageSize = request.PageSize,
                EventId = request.EventId
            };
        }
    }
}
