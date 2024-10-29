using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Shared.Features.Fighters.Responses;

public class FighterDto
{
    public int Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public string InstagramUrl { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nickname { get; set; }
    public ImageDto? Image { get; set; }
}