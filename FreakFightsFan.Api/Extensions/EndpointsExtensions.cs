using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Api.Features.DictionaryItems.Extensions;
using FreakFightsFan.Api.Features.Events.Extensions;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Api.Features.Users.Extensions;

namespace FreakFightsFan.Api.Extensions;

public static class EndpointsExtensions
{
    public static WebApplication AddEndpoints(this WebApplication app)
    {
        app.AddMyDictionaryEndpoints()
            .AddMyDictionaryItemEndpoints()
            .AddEventEndpoints()
            .AddFederationEndpoints()
            .AddFighterEndpoints()
            .AddFightEndpoints()
            .AddImageEndpoints()
            .AddTeamEndpoints()
            .AddUserEndpoints();

        return app;
    }
}