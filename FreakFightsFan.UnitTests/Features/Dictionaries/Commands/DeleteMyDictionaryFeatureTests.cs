using FluentAssertions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using MediatR;
using NSubstitute;

namespace FreakFightsFan.UnitTests.Features.Dictionaries.Commands
{
    public class DeleteMyDictionaryFeatureTests
    {
        [Fact]
        public async Task DeleteMyDictionaryHandler_ThrowsNotFoundException_IfDictionaryNotFound()
        {
            var command = new DeleteMyDictionary.Command
            {
                Id = 1,
            };

            var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
            var mediator = Substitute.For<IMediator>();

            myDictionaryRepository.Get(Arg.Any<int>()).Returns(Task.FromResult<MyDictionary>(null));

            mediator.Send(Arg.Any<DeleteMyDictionary.Command>(), CancellationToken.None)
                .Returns(callInfo =>
                {
                    var handler = new DeleteMyDictionaryFeature.Handler(myDictionaryRepository);
                    return handler.Handle(callInfo.Arg<DeleteMyDictionary.Command>(), CancellationToken.None);
                });

            var action = async () => await mediator.Send(command, CancellationToken.None);

            await Assert.ThrowsAsync<MyNotFoundException>(action);
            await myDictionaryRepository.DidNotReceive().Delete(Arg.Any<MyDictionary>());
        }

        [Fact]
        public async Task DeleteMyDictionaryHandler_DeletesValidDictionary()
        {
            var command = new DeleteMyDictionary.Command
            {
                Id = 1,
            };

            var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
            var mediator = Substitute.For<IMediator>();

            myDictionaryRepository.Get(Arg.Any<int>()).Returns(new MyDictionary());

            mediator.Send(Arg.Any<DeleteMyDictionary.Command>(), CancellationToken.None)
                .Returns(callInfo =>
                {
                    var handler = new DeleteMyDictionaryFeature.Handler(myDictionaryRepository);
                    return handler.Handle(callInfo.Arg<DeleteMyDictionary.Command>(), CancellationToken.None);
                });

            var result = await mediator.Send(command, CancellationToken.None);

            result.Should().Be(Unit.Value);
            await myDictionaryRepository.Received().Delete(Arg.Any<MyDictionary>());
        }
    }
}
