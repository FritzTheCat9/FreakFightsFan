﻿using FluentAssertions;
using FreakFightsFan.IntegrationTests.Features.Fighters.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using System.Net;
using System.Net.Http.Json;
using Xunit;
using static FreakFightsFan.IntegrationTests.TestUsers;

namespace FreakFightsFan.IntegrationTests.Features.Fighters.Commands;

public class CreateFighterFeatureTests(FreakFightsFanApiFactory apiFactory)
    : IClassFixture<FreakFightsFanApiFactory>
{
    private readonly HttpClient _client = apiFactory.CreateClient();

    [Theory]
    [ClassData(typeof(Admin))]
    [ClassData(typeof(SuperAdmin))]
    public async Task CreateFighterFeature_ShouldCreateFighter(UserBase user)
    {
        await _client.Login(user);

        var id = await _client.CreateFighter();
        var fighter = await FighterTestHelpers.GetFighter(_client, id);

        fighter.Should().NotBeNull();

        await FighterTestHelpers.DeleteFighter(_client, id);
    }

    [Theory]
    [ClassData(typeof(User))]
    public async Task CreateFighterFeature_ShouldReturnForbiddenIfUserRoleIsUser(UserBase user)
    {
        await _client.Login(user);

        var response = await _client.PostAsJsonAsync("api/fighters", new CreateFighter.Command());
        var forbiddenError = await response.Content.ReadFromJsonAsync<ForbiddenErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        forbiddenError.Should().NotBeNull();
    }

    [Fact]
    public async Task CreateFighterFeature_ShouldReturnUnauthorizedIfUserIsNotLoggedIn()
    {
        _client.Logout();

        var response = await _client.PostAsJsonAsync("api/fighters", new CreateFighter.Command());
        var unauthorizedError = await response.Content.ReadFromJsonAsync<UnauthorizedErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        unauthorizedError.Should().NotBeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("     ")]
    public async Task CreateFighterFeature_ShouldReturnValidationErrorOnInvalidFistName(string fistName)
    {
        await _client.Login(new Admin());
        var command = FighterTestHelpers.GenerateCreateFighterCommand();
        command.FirstName = fistName;

        var response = await _client.PostAsJsonAsync("api/fighters", command);
        var validationError = await response.Content.ReadFromJsonAsync<ValidationErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        validationError.Should().NotBeNull();
        validationError?.Errors.Should()
            .Contain(x => x.Key == nameof(command.FirstName) &&
                          x.Value.Any(y => y == "First name should not be empty"));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("     ")]
    public async Task CreateFighterFeature_ShouldReturnValidationErrorOnInvalidLastName(string lastName)
    {
        await _client.Login(new Admin());
        var command = FighterTestHelpers.GenerateCreateFighterCommand();
        command.LastName = lastName;

        var response = await _client.PostAsJsonAsync("api/fighters", command);
        var validationError = await response.Content.ReadFromJsonAsync<ValidationErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        validationError.Should().NotBeNull();
        validationError?.Errors.Should()
            .Contain(x => x.Key == nameof(command.LastName) &&
                          x.Value.Any(y => y == "Last name should not be empty"));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("     ")]
    public async Task CreateFighterFeature_ShouldReturnValidationErrorOnInvalidNickname(string nickname)
    {
        await _client.Login(new Admin());
        var command = FighterTestHelpers.GenerateCreateFighterCommand();
        command.Nickname = nickname;

        var response = await _client.PostAsJsonAsync("api/fighters", command);
        var validationError = await response.Content.ReadFromJsonAsync<ValidationErrorResponse>();

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        validationError.Should().NotBeNull();
        validationError?.Errors.Should()
            .Contain(
                x => x.Key == nameof(command.Nickname) &&
                     x.Value.Any(y => y == "Nickname should not be empty"));
    }
}