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
        Task<bool> DictionaryItemCodeExists(string code, int dictionaryId);
        Task<bool> DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(string code,
                                                                                  int dictionaryId,
                                                                                  int dictionaryItemId);
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

        public IQueryable<MyDictionaryItem> AsQueryable(int dictionaryId) 
            => _dbContext.MyDictionaryItems.Include(x => x.Dictionary)
                                           .Include(x => x.Events_Cities)
                                           .Include(x => x.Events_Halls)
                                           .Include(x => x.Fights_Types)
                                           .Where(x => x.DictionaryId == dictionaryId)
                                           .AsQueryable();

        public async Task<IEnumerable<MyDictionaryItem>> GetAll() 
            => await _dbContext.MyDictionaryItems.Include(x => x.Dictionary)
                                                 .Include(x => x.Events_Cities)
                                                 .Include(x => x.Events_Halls)
                                                 .Include(x => x.Fights_Types)
                                                 .ToListAsync();

        public async Task<MyDictionaryItem> Get(int id) 
            => await _dbContext.MyDictionaryItems.Include(x => x.Dictionary)
                                                 .Include(x => x.Events_Cities)
                                                 .Include(x => x.Events_Halls)
                                                 .Include(x => x.Fights_Types)
                                                 .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<bool> DictionaryItemCodeExists(string code, int dictionaryId) 
            => await _dbContext.MyDictionaryItems.AnyAsync(x => x.DictionaryId == dictionaryId
                                                                && x.Code == code);

        public async Task<bool> DictionaryItemCodeExistsInOtherDictionaryItemsInThisDictionary(string code,
                                                                                               int dictionaryId,
                                                                                               int dictionaryItemId) 
            => await _dbContext.MyDictionaryItems.Where(x => x.DictionaryId == dictionaryId
                                                             && x.Id != dictionaryItemId)
                                                 .AnyAsync(x => x.Code == code);

        public async Task<int> Create(MyDictionaryItem dictionaryItem)
        {
            await _dbContext.AddAsync(dictionaryItem);
            await _dbContext.SaveChangesAsync();
            return dictionaryItem.Id;
        }

        public Task Update(MyDictionaryItem dictionaryItem)
        {
            _dbContext.Update(dictionaryItem);
            return Task.CompletedTask;
        }

        public Task Delete(MyDictionaryItem dictionaryItem)
        {
            _dbContext.Remove(dictionaryItem);
            return Task.CompletedTask;
        }
    }
}
