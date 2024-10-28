using FluentAssertions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using MediatR;
using NSubstitute;

namespace FreakFightsFan.UnitTests.Features.Dictionaries.Queries;

public class GetAllMyDictionariesFeatureTests
{
    [Fact]
    public async Task GetAllMyDictionariesHandler_ReturnsValidDictionaryPagedList()
    {
        var command = new GetAllMyDictionaries.Query
        {
            Page = 1,
            PageSize = 10,
            SortColumn = "name",
            SortOrder = SortOrder.Ascending,
            SearchTerm = ""
        };

        var myDictionaryRepository = Substitute.For<IMyDictionaryRepository>();
        var mediator = Substitute.For<IMediator>();

        var dictionaryList = new List<MyDictionary>();
        myDictionaryRepository.AsQueryable().Returns(dictionaryList.AsQueryable());

        mediator.Send(Arg.Any<GetAllMyDictionaries.Query>(), CancellationToken.None)
            .Returns(callInfo =>
            {
                var handler = new GetAllMyDictionariesFeature.Handler(myDictionaryRepository);
                return handler.Handle(callInfo.Arg<GetAllMyDictionaries.Query>(), CancellationToken.None);
            });

        var result = await mediator.Send(command, CancellationToken.None);

        result.Should().BeOfType<PagedList<MyDictionaryDto>>();
    }
}