using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;

namespace FreakFightsFan.Api.Abstractions
{
    public static class PageListExtensions<T>
    {
        public static PagedList<T> Create(
            IQueryable<T> source,
            int page,
            int pageSize)
        {
            if (page <= 0)
                throw new MyValidationException(nameof(page), "Page should be greater than 0");
            if (pageSize <= 0)
                throw new MyValidationException(nameof(pageSize), "Page size should be greater than 0");

            var totalCount = source.Count();
            var items = source
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedList<T>(items, page, pageSize, totalCount);
        }

        public static PagedList<T> CreateEmpty(
            int page,
            int pageSize)
        {
            if (page <= 0)
                throw new MyValidationException(nameof(page), "Page should be greater than 0");
            if (pageSize <= 0)
                throw new MyValidationException(nameof(pageSize), "Page size should be greater than 0");

            return new PagedList<T>([], page, pageSize, 0);
        }
    }
}
