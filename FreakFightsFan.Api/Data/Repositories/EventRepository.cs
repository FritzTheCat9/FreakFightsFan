using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IEventRepository
    {
        IQueryable<Event> AsQueryable(int federationId);
        Task<IEnumerable<Event>> GetAll();
        Task<Event> Get(int id);
        Task<int> Create(Event myEvent);
        Task Update(Event myEvent);
        Task Delete(Event myEvent);
    }

    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _dbContext;

        public EventRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Event> AsQueryable(int federationId) => 
            _dbContext.Events
                .Include(x => x.Federation)
                .Include(x => x.City)
                .Include(x => x.Fights)
                .Where(x => x.FederationId == federationId)
                .AsQueryable();

        public async Task<IEnumerable<Event>> GetAll() => 
            await _dbContext.Events
                .Include(x => x.Federation)
                .Include(x => x.City)
                .Include(x => x.Fights)
                .ToListAsync();

        public async Task<Event> Get(int id) => 
            await _dbContext.Events
                .Include(x => x.Federation)
                .Include(x => x.City)
                .Include(x => x.Fights)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Event myEvent)
        {
            await _dbContext.AddAsync(myEvent);
            return myEvent.Id;
        }

        public Task Update(Event myEvent)
        {
            _dbContext.Update(myEvent);
            return Task.CompletedTask;
        }

        public Task Delete(Event myEvent)
        {
            _dbContext.Remove(myEvent);
            return Task.CompletedTask;
        }
    }
}
