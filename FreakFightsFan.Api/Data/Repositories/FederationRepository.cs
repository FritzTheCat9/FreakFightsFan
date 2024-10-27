using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface IFederationRepository
{
    IQueryable<Federation> AsQueryable();
    Task<IEnumerable<Federation>> GetAll();
    Task<Federation> Get(int id);
    Task<int> Create(Federation federation);
    Task Update(Federation federation);
    Task Delete(Federation federation);
}

public class FederationRepository(AppDbContext dbContext) : IFederationRepository
{
    public IQueryable<Federation> AsQueryable()
    {
        return dbContext.Federations
            .Include(x => x.Events)
            .Include(x => x.Image)
            .AsSplitQuery()
            .AsQueryable();
    }

    public async Task<IEnumerable<Federation>> GetAll()
    {
        return await dbContext.Federations
            .Include(x => x.Events)
            .Include(x => x.Image)
            .AsSplitQuery()
            .ToListAsync();
    }

    public async Task<Federation> Get(int id)
    {
        return await dbContext.Federations
            .Include(x => x.Events)
            .Include(x => x.Image)
            .AsSplitQuery()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Create(Federation federation)
    {
        await dbContext.AddAsync(federation);
        await dbContext.SaveChangesAsync();
        return federation.Id;
    }

    public Task Update(Federation federation)
    {
        dbContext.Update(federation);
        return Task.CompletedTask;
    }

    public Task Delete(Federation federation)
    {
        dbContext.Remove(federation);
        return Task.CompletedTask;
    }
}