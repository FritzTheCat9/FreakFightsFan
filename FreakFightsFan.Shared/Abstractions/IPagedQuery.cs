namespace FreakFightsFan.Shared.Abstractions;

public interface IPagedQuery
{
    int Page { get; set; }
    int PageSize { get; set; }
}