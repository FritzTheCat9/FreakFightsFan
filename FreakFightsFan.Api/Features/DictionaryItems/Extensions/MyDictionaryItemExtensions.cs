using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.DictionaryItems.Commands;
using FreakFightsFan.Api.Features.DictionaryItems.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Requests;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.DictionaryItems.Extensions
{
    public static class MyDictionaryItemExtensions
    {
        public static IEndpointRouteBuilder AddMyDictionaryItemEndpoints(this IEndpointRouteBuilder app)
        {
            CreateMyDictionaryItem.Endpoint(app);
            DeleteMyDictionaryItem.Endpoint(app);
            UpdateMyDictionaryItem.Endpoint(app);
            GetAllMyDictionaryItems.Endpoint(app);
            GetAllMyDictionaryItemsByCode.Endpoint(app);
            GetMyDictionaryItem.Endpoint(app);

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

        public static CreateMyDictionaryItem.Command ToCreateMyDictionaryItemCommand(this CreateMyDictionaryItemRequest request)
        {
            return new()
            {
                Name = request.Name,
                Code = request.Code,
                DictionaryId = request.DictionaryId,
            };
        }

        public static UpdateMyDictionaryItem.Command ToUpdateMyDictionaryItemCommand(this UpdateMyDictionaryItemRequest request, int id)
        {
            return new()
            {
                Id = id,
                Name = request.Name,
                Code = request.Code,
            };
        }

        public static GetAllMyDictionaryItems.Query ToGetAllMyDictionaryItemsQuery(this GetAllMyDictionaryItemsRequest request)
        {
            return new()
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortOrder = request.SortOrder,
                SortColumn = request.SortColumn,
                SearchTerm = request.SearchTerm,
                DictionaryId = request.DictionaryId,
            };
        }

        public static GetAllMyDictionaryItemsByCode.Query ToGetAllMyDictionaryItemsByCodeQuery(this GetAllMyDictionaryItemsByCodeRequest request)
        {
            return new()
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortOrder = request.SortOrder,
                SortColumn = request.SortColumn,
                SearchTerm = request.SearchTerm,
                DictionaryCode = request.DictionaryCode,
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
