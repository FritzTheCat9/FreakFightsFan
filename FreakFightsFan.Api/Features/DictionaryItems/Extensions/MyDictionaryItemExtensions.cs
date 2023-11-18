using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.DictionaryItems.Extensions
{
    public static class MyDictionaryItemExtensions
    {
        public static MyDictionaryItemDto ToDto(this MyDictionaryItem dictionaryItem)
        {
            return new MyDictionaryItemDto
            {
                Id = dictionaryItem.Id,
                Created = dictionaryItem.Created,
                Modified = dictionaryItem.Modified,
                Name = dictionaryItem.Name,
                Code = dictionaryItem.Code,
                DictionaryId = dictionaryItem.DictionaryId,
            };
        }

        public static IQueryable<MyDictionaryItem> FilterMyDictionaryItems(this IQueryable<MyDictionaryItem> dictionaryItems, GetAllMyDictionaryItems.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
                dictionaryItems = dictionaryItems.Where(x => 
                x.Name.ToLower().Contains(searchTerm) ||
                x.Code.ToLower().Contains(searchTerm));

            return dictionaryItems;
        }

        public static IQueryable<MyDictionaryItem> SortMyDictionaryItems(this IQueryable<MyDictionaryItem> dictionaryItems, GetAllMyDictionaryItems.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => dictionaryItems.OrderBy(GetMyDictionaryItemsSortProperty(query)),
                SortOrder.Descending => dictionaryItems.OrderByDescending(GetMyDictionaryItemsSortProperty(query)),
                SortOrder.None => dictionaryItems.OrderBy(x => x.Code),
                _ => dictionaryItems.OrderBy(x => x.Code),
            };
        }

        private static Expression<Func<MyDictionaryItem, object>> GetMyDictionaryItemsSortProperty(GetAllMyDictionaryItems.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "name" => dictionaryItem => dictionaryItem.Name,
                "code" => dictionaryItem => dictionaryItem.Code,
                _ => dictionaryItem => dictionaryItem.Code,
            };
        }
    }
}
