using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
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

    public class MyDictionaryRepository : IMyDictionaryRepository
    {
        private readonly AppDbContext _dbContext;

        public MyDictionaryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<MyDictionary> AsQueryable() => 
            _dbContext.MyDictionaries
                .Include(x => x.DictionaryItems)
                .AsQueryable();

        public async Task<IEnumerable<MyDictionary>> GetAll() => 
            await _dbContext.MyDictionaries
                .Include(x => x.DictionaryItems)
                .ToListAsync();

        public async Task<MyDictionary> Get(int id) => 
            await _dbContext.MyDictionaries
                .Include(x => x.DictionaryItems)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<MyDictionary> Get(string code) => 
            await _dbContext.MyDictionaries
                .Include(x => x.DictionaryItems)
                .FirstOrDefaultAsync(x => x.Code == code);

        public async Task<bool> DictionaryCodeExists(string code) => 
            await _dbContext.MyDictionaries
                .AnyAsync(x => x.Code == code);

        public async Task<bool> DictionaryCodeExistsInOtherDictionariesThan(string code, int dictionaryId) =>
            await _dbContext.MyDictionaries
                .Where(x => x.Id != dictionaryId)
                .AnyAsync(x => x.Code == code);

        public async Task<int> Create(MyDictionary dictionary)
        {
            await _dbContext.AddAsync(dictionary);
            await _dbContext.SaveChangesAsync();
            return dictionary.Id;
        }

        public Task Update(MyDictionary dictionary)
        {
            _dbContext.Update(dictionary);
            return Task.CompletedTask;
        }

        public Task Delete(MyDictionary dictionary)
        {
            _dbContext.Remove(dictionary);
            return Task.CompletedTask;
        }
    }
}
