using FluentAssertions;
using FreakFightsFan.Api;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using MediatR;
using Microsoft.Extensions.Localization;
using NSubstitute;

namespace FreakFightsFan.UnitTests.Features.Dictionaries.Commands;

public class CreateMyDictionaryFeatureTests
{
    private readonly IClock _clock = Substitute.For<IClock>();

    private readonly IStringLocalizer<ApiValidationMessage> _localizer =
        Substitute.For<IStringLocalizer<ApiValidationMessage>>();

    [Fact]
    public async Task CreateMyDictionaryHandler_ThrowsValidationException_IfDictionaryCodeExists()
    {
        var command = new CreateMyDictionary.Command { Name = "Test Name", Code = "TEST_CODE" };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.DictionaryCodeExists(Arg.Any<string>()).Returns(true);

        mediator.Send(Arg.Any<CreateMyDictionary.Command>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new CreateMyDictionaryFeature.Handler(myDictionaryRepository, _clock, _localizer);
                return handler.Handle(callInfo.Arg<CreateMyDictionary.Command>(), CancellationToken.None);
            });

        var action = async () => await mediator.Send(command, CancellationToken.None);

        await Assert.ThrowsAsync<MyValidationException>(action);
        await myDictionaryRepository.DidNotReceive().Create(Arg.Any<MyDictionary>());
    }

    [Fact]
    public async Task CreateMyDictionaryHandler_ReturnsValidId_ForValidDictionary()
    {
        var command = new CreateMyDictionary.Command { Name = "Test Name", Code = "TEST_CODE" };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.DictionaryCodeExists(Arg.Any<string>()).Returns(false);
        myDictionaryRepository.Create(Arg.Any<MyDictionary>()).Returns(1);

        mediator.Send(Arg.Any<CreateMyDictionary.Command>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new CreateMyDictionaryFeature.Handler(myDictionaryRepository, _clock, _localizer);
                return handler.Handle(callInfo.Arg<CreateMyDictionary.Command>(), CancellationToken.None);
            });

        var result = await mediator.Send(command, CancellationToken.None);

        result.Should().Be(1);
        await myDictionaryRepository.Received().Create(Arg.Any<MyDictionary>());
    }
}