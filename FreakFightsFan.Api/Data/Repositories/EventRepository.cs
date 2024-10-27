using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface IEventRepository
{
    IQueryable<Event> AsQueryable(int federationId);
    Task<IEnumerable<Event>> GetAll();
    Task<Event> Get(int id);
    Task<int> Create(Event myEvent);
    Task Update(Event myEvent);
    Task Delete(Event myEvent);
}

public class EventRepository(AppDbContext dbContext) : IEventRepository
{
    public IQueryable<Event> AsQueryable(int federationId)
    {
        return dbContext.Events
            .Include(x => x.Federation)
            .Include(x => x.City)
            .Include(x => x.Hall)
            .Include(x => x.Fights)
            .Where(x => x.FederationId == federationId)
            .AsSplitQuery()
            .AsQueryable();
    }

    public async Task<IEnumerable<Event>> GetAll()
    {
        return await dbContext.Events
            .Include(x => x.Federation)
            .Include(x => x.City)
            .Include(x => x.Hall)
            .Include(x => x.Fights)
            .AsSplitQuery()
            .ToListAsync();
    }

    public async Task<Event> Get(int id)
    {
        return await dbContext.Events
            .Include(x => x.Federation)
            .Include(x => x.City)
            .Include(x => x.Hall)
            .Include(x => x.Fights)
            .AsSplitQuery()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Create(Event myEvent)
    {
        await dbContext.AddAsync(myEvent);
        await dbContext.SaveChangesAsync();
        return myEvent.Id;
    }

    public Task Update(Event myEvent)
    {
        dbContext.Update(myEvent);
        return Task.CompletedTask;
    }

    public Task Delete(Event myEvent)
    {
        dbContext.Remove(myEvent);
        return Task.CompletedTask;
    }
}