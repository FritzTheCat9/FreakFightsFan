using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;

namespace FreakFightsFan.Api.Extensions
{
    public static class PageListExtensions<T>
    {
        private static readonly int _minPage = 0;
        private static readonly int _minPageSize = 0;

        public static PagedList<T> Create(
            IQueryable<T> source,
            int Page,
            int PageSize)
        {
            if (Page <= _minPage)
                throw new MyValidationException(nameof(Page), $"{nameof(Page)} should be greater than {_minPage}");
            if (PageSize <= _minPageSize)
                throw new MyValidationException(nameof(PageSize), $"{nameof(PageSize)} should be greater than {_minPageSize}");

            var totalCount = source.Count();
            var items = source
                .Skip((Page - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            return new PagedList<T>(items, Page, PageSize, totalCount);
        }

        public static PagedList<T> CreateEmpty(
            int Page,
            int PageSize)
        {
            if (Page <= _minPage)
                throw new MyValidationException(nameof(Page), $"{nameof(Page)} should be greater than {_minPage}");
            if (PageSize <= _minPageSize)
                throw new MyValidationException(nameof(PageSize), $"{nameof(PageSize)} should be greater than {_minPageSize}");

            return new PagedList<T>([], Page, PageSize, 0);
        }
    }
}
