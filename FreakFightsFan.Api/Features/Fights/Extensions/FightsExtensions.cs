using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Api.Features.Fights.Commands;
using FreakFightsFan.Api.Features.Fights.Queries;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Features.Fights.Responses;

namespace FreakFightsFan.Api.Features.Fights.Extensions;

public static class FightsExtensions
{
    public static IEndpointRouteBuilder AddFightEndpoints(this IEndpointRouteBuilder app)
    {
        CreateFightFeature.Endpoint(app);
        DeleteFightFeature.Endpoint(app);
        MoveFightFeature.Endpoint(app);
        UpdateFightFeature.Endpoint(app);
        GetAllFightsFeature.Endpoint(app);
        GetFightFeature.Endpoint(app);
        GetFighterProfileFeature.Endpoint(app);

        return app;
    }

    public static FightDto ToDto(this Fight fight)
    {
        return new FightDto
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
}