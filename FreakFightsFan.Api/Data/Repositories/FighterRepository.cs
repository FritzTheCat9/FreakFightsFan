using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface IFighterRepository
{
    IQueryable<Fighter> AsQueryable();
    Task<IEnumerable<Fighter>> GetAll();
    Task<Fighter> Get(int id);
    Task<int> Create(Fighter fighter);
    Task Update(Fighter fighter);
    Task Delete(Fighter fighter);
    Task SaveChanges();
}

public class FighterRepository(AppDbContext dbContext) : IFighterRepository
{
    public IQueryable<Fighter> AsQueryable()
    {
        return dbContext.Fighters
            .Include(x => x.Image)
            .Include(x => x.Teams)
            .Include(x => x.TeamFighters)
            .AsSplitQuery()
            .AsQueryable();
    }

    public async Task<IEnumerable<Fighter>> GetAll()
    {
        return await dbContext.Fighters
            .Include(x => x.Image)
            .Include(x => x.Teams)
            .Include(x => x.TeamFighters)
            .AsSplitQuery()
            .ToListAsync();
    }

    public async Task<Fighter> Get(int id)
    {
        return await dbContext.Fighters
            .Include(x => x.Image)
            .Include(x => x.Teams)
            .Include(x => x.TeamFighters)
            .AsSplitQuery()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Create(Fighter fighter)
    {
        await dbContext.AddAsync(fighter);
        await dbContext.SaveChangesAsync();
        return fighter.Id;
    }

    public Task Update(Fighter fighter)
    {
        dbContext.Update(fighter);
        return Task.CompletedTask;
    }

    public Task Delete(Fighter fighter)
    {
        dbContext.Remove(fighter);
        return Task.CompletedTask;
    }

    public async Task SaveChanges()
    {
        await dbContext.SaveChangesAsync();
    }
}