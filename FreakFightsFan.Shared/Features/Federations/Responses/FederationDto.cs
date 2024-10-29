using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Shared.Features.Federations.Responses;

public class FederationDto
{
    public int Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public string Name { get; set; }
    public ImageDto? Image { get; set; }
}