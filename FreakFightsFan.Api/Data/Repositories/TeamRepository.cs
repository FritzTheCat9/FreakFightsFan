using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface ITeamRepository
{
    IQueryable<Team> AsQueryable();
    Task<IEnumerable<Team>> GetAll();
    Task<Team> Get(int id);
    Task<int> Create(Team team);
    Task Update(Team team);
    Task Delete(Team team);
}

public class TeamRepository(AppDbContext dbContext) : ITeamRepository
{
    public IQueryable<Team> AsQueryable()
    {
        return dbContext.Teams
            .Include(x => x.Fight)
            .Include(x => x.Fighters)
            .Include(x => x.TeamFighters)
            .OrderBy(x => x.Id)
            .AsSplitQuery()
            .AsQueryable();
    }

    public async Task<IEnumerable<Team>> GetAll()
    {
        return await dbContext.Teams
            .Include(x => x.Fight)
            .Include(x => x.Fighters)
            .Include(x => x.TeamFighters)
            .AsSplitQuery()
            .ToListAsync();
    }

    public async Task<Team> Get(int id)
    {
        return await dbContext.Teams
            .Include(x => x.Fight)
            .Include(x => x.Fighters)
            .Include(x => x.TeamFighters)
            .AsSplitQuery()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Create(Team team)
    {
        await dbContext.AddAsync(team);
        await dbContext.SaveChangesAsync();
        return team.Id;
    }

    public Task Update(Team team)
    {
        dbContext.Update(team);
        return Task.CompletedTask;
    }

    public Task Delete(Team team)
    {
        dbContext.Remove(team);
        return Task.CompletedTask;
    }
}