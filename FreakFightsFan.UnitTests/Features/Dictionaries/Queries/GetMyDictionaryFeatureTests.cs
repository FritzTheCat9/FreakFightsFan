using FluentAssertions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using MediatR;
using NSubstitute;

namespace FreakFightsFan.UnitTests.Features.Dictionaries.Queries;

public class GetMyDictionaryFeatureTests
{
    [Fact]
    public async Task GetMyDictionaryHandler_ThrowsNotFoundException_IfDictionaryNotFound()
    {
        var command = new GetMyDictionary.Query { Id = 1 };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.Get(Arg.Any<int>()).Returns(Task.FromResult<MyDictionary>(null));

        mediator.Send(Arg.Any<GetMyDictionary.Query>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new GetMyDictionaryFeature.Handler(myDictionaryRepository);
                return handler.Handle(callInfo.Arg<GetMyDictionary.Query>(), CancellationToken.None);
            });

        var action = async () => await mediator.Send(command, CancellationToken.None);

        await Assert.ThrowsAsync<MyNotFoundException>(action);
    }

    [Fact]
    public async Task GetMyDictionaryHandler_ReturnsValidDictionary()
    {
        var command = new GetMyDictionary.Query { Id = 1 };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        myDictionaryRepository.Get(Arg.Any<int>()).Returns(new MyDictionary());

        mediator.Send(Arg.Any<GetMyDictionary.Query>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new GetMyDictionaryFeature.Handler(myDictionaryRepository);
                return handler.Handle(callInfo.Arg<GetMyDictionary.Query>(), CancellationToken.None);
            });

        var result = await mediator.Send(command, CancellationToken.None);

        result.Should().BeOfType<MyDictionaryDto>();
    }
}