using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IMyDictionaryItemRepository
    {
        IQueryable<MyDictionaryItem> AsQueryable(int dictionaryId);
        Task<IEnumerable<MyDictionaryItem>> GetAll();
        Task<MyDictionaryItem> Get(int id);
        Task<bool> DictionaryItemNameExists(string name, int dictionaryId);
        Task<bool> DictionaryItemNameExistsInOtherDictionaryItemsInThisDictionary(string name, int dictionaryId, int dictionaryItemId);
        Task<int> Create(MyDictionaryItem dictionaryItem);
        Task Update(MyDictionaryItem dictionaryItem);
        Task Delete(MyDictionaryItem dictionaryItem);
    }

    public class MyDictionaryItemRepository : IMyDictionaryItemRepository
    {
        private readonly AppDbContext _dbContext;

        public MyDictionaryItemRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<MyDictionaryItem> AsQueryable(int dictionaryId) => 
            _dbContext.MyDictionaryItems
                .Where(x => x.DictionaryId == dictionaryId)
                .AsQueryable();

        public async Task<IEnumerable<MyDictionaryItem>> GetAll() => await _dbContext.MyDictionaryItems.ToListAsync();

        public async Task<MyDictionaryItem> Get(int id) => await _dbContext.MyDictionaryItems.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<bool> DictionaryItemNameExists(string name, int dictionaryId) =>
            await _dbContext.MyDictionaryItems
                .AnyAsync(x => x.DictionaryId == dictionaryId && x.Name == name);

        public async Task<bool> DictionaryItemNameExistsInOtherDictionaryItemsInThisDictionary(string name, int dictionaryId, int dictionaryItemId) =>
            await _dbContext.MyDictionaryItems
                .Where(x => x.DictionaryId == dictionaryId && x.Id != dictionaryItemId)
                .AnyAsync(x => x.Name == name);

        public async Task<int> Create(MyDictionaryItem dictionaryItem)
        {
            await _dbContext.AddAsync(dictionaryItem);
            await _dbContext.SaveChangesAsync();
            return dictionaryItem.Id;
        }

        public async Task Update(MyDictionaryItem dictionaryItem)
        {
            _dbContext.Update(dictionaryItem);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(MyDictionaryItem dictionaryItem)
        {
            _dbContext.Remove(dictionaryItem);
            await _dbContext.SaveChangesAsync();
        }
    }
}
