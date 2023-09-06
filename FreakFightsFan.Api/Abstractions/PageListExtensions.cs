using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Abstractions
{
    public static class PageListExtensions<T>
    {
        public static async Task<PagedList<T>> CreateAsync(
            IQueryable<T> source, 
            int page, 
            int pageSize, 
            CancellationToken cancellationToken)
        {
            if (page <= 0) 
                throw new MyValidationException(nameof(page), "Page should be greater than 0");
            if (pageSize <= 0)
                throw new MyValidationException(nameof(pageSize), "Page size should be greater than 0");

            var totalCount = await source.CountAsync(cancellationToken);
            var items = await source
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);

            return new PagedList<T>(items, page, pageSize, totalCount);
        }
    }
}
