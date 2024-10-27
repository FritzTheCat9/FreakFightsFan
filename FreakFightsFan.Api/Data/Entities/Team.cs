namespace FreakFightsFan.Api.Data.Entities;

public class Team : Entity
{
    public int Number { get; set; }

    public int FightId { get; set; }
    public Fight Fight { get; set; }
    public List<Fighter> Fighters { get; } = [];
    public List<TeamFighter> TeamFighters { get; } = [];
}