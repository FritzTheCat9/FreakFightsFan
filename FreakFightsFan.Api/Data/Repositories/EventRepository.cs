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
                .Include(x => x.City)
                .Where(x => x.FederationId == federationId)
                .AsQueryable();

        public async Task<IEnumerable<Event>> GetAll() => 
            await _dbContext.Events
                .Include(x => x.City)
                .ToListAsync();

        public async Task<Event> Get(int id) => 
            await _dbContext.Events
                .Include(x => x.City)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Event myEvent)
        {
            await _dbContext.AddAsync(myEvent);
            await _dbContext.SaveChangesAsync();
            return myEvent.Id;
        }

        public async Task Update(Event myEvent)
        {
            _dbContext.Update(myEvent);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Event myEvent)
        {
            _dbContext.Remove(myEvent);
            await _dbContext.SaveChangesAsync();
        }
    }
}
