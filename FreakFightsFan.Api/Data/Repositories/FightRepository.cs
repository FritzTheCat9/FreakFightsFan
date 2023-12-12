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
        Task UpdateRange(List<Fight> fights);
        Task Delete(Fight fight);
        Task OrderFights(int eventId, int deletedId);
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
                .OrderByDescending(x => x.OrderNumber)
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
            return fight.Id;
        }

        public Task Update(Fight fight)
        {
            _dbContext.Update(fight);
            return Task.CompletedTask;
        }

        public Task Delete(Fight fight)
        {
            _dbContext.Remove(fight);
            return Task.CompletedTask;
        }

        public Task UpdateRange(List<Fight> fights)
        {
            _dbContext.UpdateRange(fights);
            return Task.CompletedTask;
        }

        public Task OrderFights(int eventId, int deletedId)
        {
            _dbContext.Fights
                .Where(x => x.EventId == eventId && x.Id > deletedId)
                .ToList().ForEach((x) =>
                {
                    x.OrderNumber--;
                });

            return Task.CompletedTask;
        }
    }
}
