namespace FreakFightsFan.Shared.Features.Images.Responses;

public class ImageDto
{
    public int Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public string Name { get; set; }
    public string Url { get; set; }
}