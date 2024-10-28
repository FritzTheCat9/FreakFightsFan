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

public class UpdateMyDictionaryFeatureTests
{
    private readonly IClock _clock = Substitute.For<IClock>();

    private readonly IStringLocalizer<ApiValidationMessage> _localizer =
        Substitute.For<IStringLocalizer<ApiValidationMessage>>();

    [Fact]
    public async Task UpdateMyDictionaryHandler_ThrowsNotFoundException_IfDictionaryNotFound()
    {
        var command = new UpdateMyDictionary.Command { Id = 1, Name = "Test Name", Code = "TEST_CODE" };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.Get(Arg.Any<int>()).Returns(Task.FromResult<MyDictionary>(null));

        mediator.Send(Arg.Any<UpdateMyDictionary.Command>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new UpdateMyDictionaryFeature.Handler(myDictionaryRepository, _clock, _localizer);
                return handler.Handle(callInfo.Arg<UpdateMyDictionary.Command>(), CancellationToken.None);
            });

        var action = async () => await mediator.Send(command, CancellationToken.None);

        await Assert.ThrowsAsync<MyNotFoundException>(action);
        await myDictionaryRepository.DidNotReceive().Update(Arg.Any<MyDictionary>());
    }

    [Fact]
    public async Task UpdateMyDictionaryHandler_ThrowsValidationException_IfCodeExistsInOtherDictionaries()
    {
        var command = new UpdateMyDictionary.Command { Id = 1, Name = "Test Name", Code = "TEST_CODE" };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.Get(Arg.Any<int>()).Returns(new MyDictionary());
        myDictionaryRepository.DictionaryCodeExistsInOtherDictionariesThan(Arg.Any<string>(), Arg.Any<int>())
            .Returns(true);

        mediator.Send(Arg.Any<UpdateMyDictionary.Command>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new UpdateMyDictionaryFeature.Handler(myDictionaryRepository, _clock, _localizer);
                return handler.Handle(callInfo.Arg<UpdateMyDictionary.Command>(), CancellationToken.None);
            });

        var action = async () => await mediator.Send(command, CancellationToken.None);

        await Assert.ThrowsAsync<MyValidationException>(action);
        await myDictionaryRepository.DidNotReceive().Update(Arg.Any<MyDictionary>());
    }

    [Fact]
    public async Task UpdateMyDictionaryHandler_UpdatesValidDictionary()
    {
        var command = new UpdateMyDictionary.Command { Id = 1, Name = "Test Name", Code = "TEST_CODE" };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.Get(Arg.Any<int>()).Returns(new MyDictionary());
        myDictionaryRepository.DictionaryCodeExistsInOtherDictionariesThan(Arg.Any<string>(), Arg.Any<int>())
            .Returns(false);

        mediator.Send(Arg.Any<UpdateMyDictionary.Command>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new UpdateMyDictionaryFeature.Handler(myDictionaryRepository, _clock, _localizer);
                return handler.Handle(callInfo.Arg<UpdateMyDictionary.Command>(), CancellationToken.None);
            });

        var result = await mediator.Send(command, CancellationToken.None);

        result.Should().Be(Unit.Value);
        await myDictionaryRepository.Received().Update(Arg.Any<MyDictionary>());
    }
}