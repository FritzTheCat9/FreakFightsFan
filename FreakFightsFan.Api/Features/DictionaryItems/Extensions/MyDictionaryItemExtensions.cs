using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Commands;
using FreakFightsFan.Api.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.DictionaryItems.Extensions
{
    public static class MyDictionaryItemExtensions
    {
        public static IEndpointRouteBuilder AddMyDictionaryItemEndpoints(this IEndpointRouteBuilder app)
        {
            CreateMyDictionaryItemFeature.Endpoint(app);
            DeleteMyDictionaryItemFeature.Endpoint(app);
            UpdateMyDictionaryItemFeature.Endpoint(app);
            GetAllMyDictionaryItemsFeature.Endpoint(app);
            GetAllMyDictionaryItemsByCodeFeature.Endpoint(app);
            GetMyDictionaryItemFeature.Endpoint(app);

            return app;
        }

        public static MyDictionaryItemDto ToDto(this MyDictionaryItem dictionaryItem)
        {
            return new()
            {
                Id = dictionaryItem.Id,
                Created = dictionaryItem.Created,
                Modified = dictionaryItem.Modified,
                Name = dictionaryItem.Name,
                Code = dictionaryItem.Code,
                DictionaryId = dictionaryItem.DictionaryId,
            };
        }

        /* GetAllMyDictionaryItems.Query */

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

        /* GetAllMyDictionaryItemsByCode.Query */

        public static IQueryable<MyDictionaryItem> FilterMyDictionaryItems(this IQueryable<MyDictionaryItem> dictionaryItems, GetAllMyDictionaryItemsByCode.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
                dictionaryItems = dictionaryItems.Where(x =>
                    x.Name.ToLower().Contains(searchTerm) ||
                    x.Code.ToLower().Contains(searchTerm));

            return dictionaryItems;
        }

        public static IQueryable<MyDictionaryItem> SortMyDictionaryItems(this IQueryable<MyDictionaryItem> dictionaryItems, GetAllMyDictionaryItemsByCode.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => dictionaryItems.OrderBy(GetMyDictionaryItemsSortProperty(query)),
                SortOrder.Descending => dictionaryItems.OrderByDescending(GetMyDictionaryItemsSortProperty(query)),
                SortOrder.None => dictionaryItems.OrderBy(x => x.Code),
                _ => dictionaryItems.OrderBy(x => x.Code),
            };
        }

        private static Expression<Func<MyDictionaryItem, object>> GetMyDictionaryItemsSortProperty(GetAllMyDictionaryItemsByCode.Query query)
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
