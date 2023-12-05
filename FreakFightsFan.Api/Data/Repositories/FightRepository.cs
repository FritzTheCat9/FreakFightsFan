using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IFightRepository
    {
        IQueryable<Fight> AsQueryable(int eventId);
        Task<IEnumerable<Fight>> GetAll();
        Task<Fight> Get(int id);
        Task<int> Create(Fight fight);
        Task Update(Fight fight);
        Task Delete(Fight fight);
    }

    public class FightRepository : IFightRepository
    {
        private readonly AppDbContext _dbContext;

        public FightRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Fight> AsQueryable(int eventId) => 
            _dbContext.Fights
                .Include(x => x.Event)
                .Include(x => x.Teams)
                    .ThenInclude(x => x.Fighters)
                        .ThenInclude(x => x.Image)
                .Where(x => x.EventId == eventId)
                .AsQueryable();

        public async Task<IEnumerable<Fight>> GetAll() => 
            await _dbContext.Fights
                .Include(x => x.Event)
                .Include(x => x.Teams)
                    .ThenInclude(x => x.Fighters)
                        .ThenInclude(x => x.Image)
                .ToListAsync();

        public async Task<Fight> Get(int id) => 
            await _dbContext.Fights
                .Include(x => x.Event)
                .Include(x => x.Teams)
                    .ThenInclude(x => x.Fighters)
                        .ThenInclude(x => x.Image)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Fight fight)
        {
            await _dbContext.AddAsync(fight);
            await _dbContext.SaveChangesAsync();
            return fight.Id;
        }

        public async Task Update(Fight fight)
        {
            _dbContext.Update(fight);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Fight fight)
        {
            _dbContext.Remove(fight);
            await _dbContext.SaveChangesAsync();
        }
    }
}
