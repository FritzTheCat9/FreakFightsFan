using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface IMyDictionaryItemRepository
{
    IQueryable<MyDictionaryItem> AsQueryable(int dictionaryId);
    Task<IEnumerable<MyDictionaryItem>> GetAll();
    Task<MyDictionaryItem> Get(int id);
    Task<bool> DictionaryItemCodeExists(string code, int dictionaryId);

    Task<bool> DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(string code,
        int dictionaryId,
        int dictionaryItemId);

    Task<int> Create(MyDictionaryItem dictionaryItem);
    Task Update(MyDictionaryItem dictionaryItem);
    Task Delete(MyDictionaryItem dictionaryItem);
}

public class MyDictionaryItemRepository(AppDbContext dbContext) : IMyDictionaryItemRepository
{
    public IQueryable<MyDictionaryItem> AsQueryable(int dictionaryId)
    {
        return dbContext.MyDictionaryItems
            .Include(x => x.Dictionary)
            .Include(x => x.EventsCities)
            .Include(x => x.EventsHalls)
            .Include(x => x.FightsTypes)
            .Where(x => x.DictionaryId == dictionaryId)
            .AsSplitQuery()
            .AsQueryable();
    }

    public async Task<IEnumerable<MyDictionaryItem>> GetAll()
    {
        return await dbContext.MyDictionaryItems
            .Include(x => x.Dictionary)
            .Include(x => x.EventsCities)
            .Include(x => x.EventsHalls)
            .Include(x => x.FightsTypes)
            .AsSplitQuery()
            .ToListAsync();
    }

    public async Task<MyDictionaryItem> Get(int id)
    {
        return await dbContext.MyDictionaryItems
            .Include(x => x.Dictionary)
            .Include(x => x.EventsCities)
            .Include(x => x.EventsHalls)
            .Include(x => x.FightsTypes)
            .AsSplitQuery()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<bool> DictionaryItemCodeExists(string code, int dictionaryId)
    {
        return await dbContext.MyDictionaryItems
            .AnyAsync(x => x.DictionaryId == dictionaryId
                           && x.Code == code);
    }

    public async Task<bool> DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(string code,
        int dictionaryId,
        int dictionaryItemId)
    {
        return await dbContext.MyDictionaryItems
            .Where(x => x.DictionaryId == dictionaryId
                        && x.Id != dictionaryItemId)
            .AnyAsync(x => x.Code == code);
    }

    public async Task<int> Create(MyDictionaryItem dictionaryItem)
    {
        await dbContext.AddAsync(dictionaryItem);
        await dbContext.SaveChangesAsync();
        return dictionaryItem.Id;
    }

    public Task Update(MyDictionaryItem dictionaryItem)
    {
        dbContext.Update(dictionaryItem);
        return Task.CompletedTask;
    }

    public Task Delete(MyDictionaryItem dictionaryItem)
    {
        dbContext.Remove(dictionaryItem);
        return Task.CompletedTask;
    }
}