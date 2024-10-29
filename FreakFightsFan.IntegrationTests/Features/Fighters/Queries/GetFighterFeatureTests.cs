using FluentAssertions;
using FreakFightsFan.IntegrationTests.Features.Fighters.Helpers;
using FreakFightsFan.Shared.Exceptions;
using System.Net;
using System.Net.Http.Json;
using Xunit;

namespace FreakFightsFan.IntegrationTests.Features.Fighters.Queries;

public class GetFighterFeatureTests(FreakFightsFanApiFactory apiFactory) : IClassFixture<FreakFightsFanApiFactory>
{
    private readonly HttpClient _client = apiFactory.CreateClient();

    [Fact]
    public async Task GetFighterFeature_ShouldReturnFighter()
    {
        await _client.Login(new TestUsers.Admin());
        var id = await _client.CreateFighter();
        _client.Logout();

        var fighter = await FighterTestHelpers.GetFighter(_client, id);
        fighter.Should().NotBeNull();

        await _client.Login(new TestUsers.Admin());
        await FighterTestHelpers.DeleteFighter(_client, id);
        _client.Logout();
    }

    [Fact]
    public async Task GetFighterFeature_ShouldReturnNotFoundErrorIfFighterDoesNotExist()
    {
        const int id = int.MaxValue;
        var response = await _client.GetAsync($"api/fighters/{id}");
        var notFoundError = await response.Content.ReadFromJsonAsync<NotFoundErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        notFoundError.Should().NotBeNull();
    }
}