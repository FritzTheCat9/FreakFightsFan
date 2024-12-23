﻿using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;

namespace FreakFightsFan.Api.Extensions;

public static class PageListExtensions<T>
{
    private const int _minPage = 0;
    private const int _minPageSize = 0;
    private const int _maxPageSize = 100;

    public static PagedList<T> Create(
        IQueryable<T> source,
        int page,
        int pageSize)
    {
        Validate(page, pageSize);

        var totalCount = source.Count();
        var items = source.Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return new PagedList<T>(items, page, pageSize, totalCount);
    }

    public static PagedList<T> CreateEmpty(
        int page,
        int pageSize)
    {
        Validate(page, pageSize);

        return new PagedList<T>([], page, pageSize, 0);
    }

    private static void Validate(int page, int pageSize)
    {
        if (page <= _minPage)
        {
            throw new MyValidationException(nameof(page), $"{nameof(page)} should be greater than {_minPage}");
        }

        switch (pageSize)
        {
            case <= _minPageSize:
                throw new MyValidationException(nameof(pageSize),
                    $"{nameof(pageSize)} should be greater than {_minPageSize}");
            case > _maxPageSize:
                throw new MyValidationException(nameof(pageSize),
                    $"{nameof(pageSize)} should be less than or equal to {_maxPageSize}");
        }
    }
}