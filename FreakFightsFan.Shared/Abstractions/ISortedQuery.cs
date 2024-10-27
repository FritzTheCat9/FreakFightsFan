namespace FreakFightsFan.Shared.Abstractions;

public interface ISortedQuery
{
    public string SortColumn { get; set; }
    public SortOrder SortOrder { get; set; }
}