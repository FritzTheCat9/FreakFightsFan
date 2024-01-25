using System.Net.Http.Json;
using System.Net;
using Xunit;
using FluentAssertions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.IntegrationTests.Features.Fighters.Helpers;

namespace FreakFightsFan.IntegrationTests.Features.Fighters.Queries
{
    public class GetFighterFeatureTests : IClassFixture<FreakFightsFanApiFactory>
    {
        private readonly HttpClient _client;

        public GetFighterFeatureTests(FreakFightsFanApiFactory apiFactory)
        {
            _client = apiFactory.CreateClient();
        }

        [Fact]
        public async Task GetFighterFeature_ShouldReturnFighter()
        {
            await _client.Login(new TestUsers.Admin());
            var id = await FighterTestHelpers.CreateFighter(_client);
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
            int id = int.MaxValue;
            var response = await _client.GetAsync($"api/fighters/{id}");
            var notFoundError = await response.Content.ReadFromJsonAsync<NotFoundErrorResponse>();

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            notFoundError.Should().NotBeNull();
        }
    }
}
