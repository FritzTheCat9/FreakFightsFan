using FluentAssertions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using System.Net;
using System.Net.Http.Json;
using Xunit;

namespace FreakFightsFan.IntegrationTests.Features.Fighters.Queries;

public class GetAllFightersFeatureTests(FreakFightsFanApiFactory apiFactory)
    : IClassFixture<FreakFightsFanApiFactory>
{
    private readonly HttpClient _client = apiFactory.CreateClient();

    [Fact]
    public async Task GetAllFightersFeature_ShouldReturnPagedListOfFighters()
    {
        var query = new GetAllFighters.Query
        {
            Page = 1,
            PageSize = 10,
            SortColumn = "nickname",
            SortOrder = SortOrder.Ascending,
            SearchTerm = "",
            HiddenFightersIds = null
        };

        var response = await _client.PostAsJsonAsync("api/fighters/all", query);
        var fighters = await response.Content.ReadFromJsonAsync<PagedList<FighterDto>>();

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        fighters.Should().NotBeNull();
    }

    [Fact]
    public async Task GetAllFightersFeature_ShouldReturnValidationErrorOnInvalidPage()
    {
        var minPage = 0;
        var query = new GetAllFighters.Query
        {
            Page = minPage,
            PageSize = 10,
            SortColumn = "nickname",
            SortOrder = SortOrder.Ascending,
            SearchTerm = "",
            HiddenFightersIds = null
        };

        var response = await _client.PostAsJsonAsync("api/fighters/all", query);
        var validationError = await response.Content.ReadFromJsonAsync<ValidationErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        validationError.Should().NotBeNull();
        validationError?.Errors.Should()
            .Contain(x => x.Key == nameof(query.Page) && x.Value.Any(x => x == $"{nameof(query.Page)} should be greater than {minPage}"));
    }

    [Fact]
    public async Task GetAllFightersFeature_ShouldReturnValidationErrorOnInvalidPageSize()
    {
        var minPageSize = 0;
        var query = new GetAllFighters.Query
        {
            Page = 1,
            PageSize = minPageSize,
            SortColumn = "nickname",
            SortOrder = SortOrder.Ascending,
            SearchTerm = "",
            HiddenFightersIds = null
        };

        var response = await _client.PostAsJsonAsync("api/fighters/all", query);
        var validationError = await response.Content.ReadFromJsonAsync<ValidationErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        validationError.Should().NotBeNull();
        validationError?.Errors.Should()
            .Contain(x => x.Key == nameof(query.PageSize) && x.Value.Any(x => x == $"{nameof(query.PageSize)} should be greater than {minPageSize}"));
    }
}