using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface IMyDictionaryRepository
{
    IQueryable<MyDictionary> AsQueryable();
    Task<IEnumerable<MyDictionary>> GetAll();
    Task<MyDictionary> Get(int id);
    Task<MyDictionary> Get(string code);
    Task<bool> DictionaryCodeExists(string code);
    Task<bool> DictionaryCodeExistsInOtherDictionariesThan(string code, int dictionaryId);
    Task<int> Create(MyDictionary dictionary);
    Task Update(MyDictionary dictionary);
    Task Delete(MyDictionary dictionary);
}

public class MyDictionaryRepository(AppDbContext dbContext) : IMyDictionaryRepository
{
    public IQueryable<MyDictionary> AsQueryable()
    {
        return dbContext.MyDictionaries
            .Include(x => x.DictionaryItems)
            .AsQueryable();
    }

    public async Task<IEnumerable<MyDictionary>> GetAll()
    {
        return await dbContext.MyDictionaries
            .Include(x => x.DictionaryItems)
            .ToListAsync();
    }

    public async Task<MyDictionary> Get(int id)
    {
        return await dbContext.MyDictionaries
            .Include(x => x.DictionaryItems)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<MyDictionary> Get(string code)
    {
        return await dbContext.MyDictionaries
            .Include(x => x.DictionaryItems)
            .FirstOrDefaultAsync(x => x.Code == code);
    }

    public async Task<bool> DictionaryCodeExists(string code)
    {
        return await dbContext.MyDictionaries
            .AnyAsync(x => x.Code == code);
    }

    public async Task<bool> DictionaryCodeExistsInOtherDictionariesThan(string code, int dictionaryId)
    {
        return await dbContext.MyDictionaries
            .Where(x => x.Id != dictionaryId)
            .AnyAsync(x => x.Code == code);
    }

    public async Task<int> Create(MyDictionary dictionary)
    {
        await dbContext.AddAsync(dictionary);
        await dbContext.SaveChangesAsync();
        return dictionary.Id;
    }

    public Task Update(MyDictionary dictionary)
    {
        dbContext.Update(dictionary);
        return Task.CompletedTask;
    }

    public Task Delete(MyDictionary dictionary)
    {
        dbContext.Remove(dictionary);
        return Task.CompletedTask;
    }
}