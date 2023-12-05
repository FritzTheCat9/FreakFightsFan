using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Dictionaries.Commands;
using FreakFightsFan.Api.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Dictionaries.Extensions
{
    public static class MyDictionaryExtensions
    {
        public static IEndpointRouteBuilder AddMyDictionaryEndpoints(this IEndpointRouteBuilder app)
        {
            CreateMyDictionary.Endpoint(app);
            DeleteMyDictionary.Endpoint(app);
            UpdateMyDictionary.Endpoint(app);
            GetAllMyDictionaries.Endpoint(app);
            GetMyDictionary.Endpoint(app);

            return app;
        }

        public static MyDictionaryDto ToDto(this MyDictionary dictionary)
        {
            return new MyDictionaryDto
            {
                Id = dictionary.Id,
                Created = dictionary.Created,
                Modified = dictionary.Modified,
                Name = dictionary.Name,
                Code = dictionary.Code,
            };
        }

        public static CreateMyDictionary.Command ToCreateMyDictionaryCommand(this CreateMyDictionaryRequest request)
        {
            return new CreateMyDictionary.Command
            {
                Name = request.Name,
                Code = request.Code,
            };
        }

        public static UpdateMyDictionary.Command ToUpdateMyDictionaryCommand(this UpdateMyDictionaryRequest request, int id)
        {
            return new UpdateMyDictionary.Command
            {
                Id = id,
                Name = request.Name,
                Code = request.Code,
            };
        }

        public static GetAllMyDictionaries.Query ToGetAllMyDictionariesQuery(this GetAllMyDictionariesRequest request)
        {
            return new GetAllMyDictionaries.Query
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortOrder = request.SortOrder,
                SortColumn = request.SortColumn,
                SearchTerm = request.SearchTerm,
            };
        }

        public static IQueryable<MyDictionary> FilterMyDictionaries(this IQueryable<MyDictionary> dictionaries, GetAllMyDictionaries.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
                dictionaries = dictionaries.Where(x => 
                    x.Name.ToLower().Contains(searchTerm) ||
                    x.Code.ToLower().Contains(searchTerm));

            return dictionaries;
        }

        public static IQueryable<MyDictionary> SortMyDictionaries(this IQueryable<MyDictionary> dictionaries, GetAllMyDictionaries.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => dictionaries.OrderBy(GetMyDictionarySortProperty(query)),
                SortOrder.Descending => dictionaries.OrderByDescending(GetMyDictionarySortProperty(query)),
                SortOrder.None => dictionaries.OrderBy(x => x.Code),
                _ => dictionaries.OrderBy(x => x.Code),
            };
        }

        private static Expression<Func<MyDictionary, object>> GetMyDictionarySortProperty(GetAllMyDictionaries.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => dictionary => dictionary.Name,
                "code" => dictionary => dictionary.Code,
                _ => dictionary => dictionary.Code,
            };
        }
    }
}
