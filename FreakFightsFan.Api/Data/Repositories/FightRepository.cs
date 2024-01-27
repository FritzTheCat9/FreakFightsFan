using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IFightRepository
    {
        IQueryable<Fight> AsQueryable(int eventId);
        Task<IEnumerable<Fight>> GetAll();
        Task<IEnumerable<Fight>> GetFighterFights(int fighterId);
        Task<Fight> Get(int id);
        Task<int> Create(Fight fight);
        Task Update(Fight fight);
        Task UpdateRange(List<Fight> fights);
        Task Delete(Fight fight);
        Task OrderFights(int eventId, int deletedOrderNumber);
    }

    public class FightRepository : IFightRepository
    {
        private readonly AppDbContext _dbContext;

        public FightRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Fight> AsQueryable(int eventId)
            => _dbContext.Fights.Include(x => x.Event)
                                    .ThenInclude(x => x.City)
                                .Include(x => x.Event)
                                    .ThenInclude(x => x.Hall)
                                .Include(x => x.Teams)
                                    .ThenInclude(x => x.Fighters)
                                        .ThenInclude(x => x.Image)
                                .Include(x => x.Teams)
                                    .ThenInclude(x => x.TeamFighters)
                                        .ThenInclude(x => x.Fighter)
                                            .ThenInclude(x => x.Image)
                                .Include(x => x.Type)
                                .Where(x => x.EventId == eventId)
                                .OrderByDescending(x => x.OrderNumber)
                                .AsQueryable();

        public async Task<IEnumerable<Fight>> GetAll()
            => await _dbContext.Fights.Include(x => x.Event)
                                        .ThenInclude(x => x.City)
                                      .Include(x => x.Event)
                                        .ThenInclude(x => x.Hall)
                                      .Include(x => x.Teams)
                                        .ThenInclude(x => x.Fighters)
                                            .ThenInclude(x => x.Image)
                                      .Include(x => x.Teams)
                                        .ThenInclude(x => x.TeamFighters)
                                            .ThenInclude(x => x.Fighter)
                                                .ThenInclude(x => x.Image)
                                      .Include(x => x.Type)
                                      .ToListAsync();


        public async Task<IEnumerable<Fight>> GetFighterFights(int fighterId)
            => await _dbContext.Fights.Where(x => x.Teams.Any(x => x.TeamFighters.Any(x => x.FighterId == fighterId)))
                                      .OrderByDescending(x => x.Event.Date)
                                      .Include(x => x.Event)
                                        .ThenInclude(x => x.City)
                                      .Include(x => x.Event)
                                        .ThenInclude(x => x.Hall)
                                      .Include(x => x.Teams)
                                        .ThenInclude(x => x.Fighters)
                                            .ThenInclude(x => x.Image)
                                      .Include(x => x.Teams)
                                        .ThenInclude(x => x.TeamFighters)
                                            .ThenInclude(x => x.Fighter)
                                                .ThenInclude(x => x.Image)
                                      .Include(x => x.Type)
                                      .ToListAsync();

        public async Task<Fight> Get(int id) 
            => await _dbContext.Fights.Include(x => x.Event)
                                        .ThenInclude(x => x.City)
                                      .Include(x => x.Event)
                                        .ThenInclude(x => x.Hall)
                                      .Include(x => x.Teams)
                                        .ThenInclude(x => x.Fighters)
                                            .ThenInclude(x => x.Image)
                                      .Include(x => x.Teams)
                                        .ThenInclude(x => x.TeamFighters)
                                            .ThenInclude(x => x.Fighter)
                                                .ThenInclude(x => x.Image)
                                      .Include(x => x.Type)
                                      .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Fight fight)
        {
            await _dbContext.AddAsync(fight);
            await _dbContext.SaveChangesAsync();
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

        public async Task OrderFights(int eventId, int deletedOrderNumber)
        {
            var fightsToUpdate = await _dbContext.Fights.Where(x => x.EventId == eventId
                                                                    && x.OrderNumber > deletedOrderNumber)
                                                        .ToListAsync();

            foreach (var fight in fightsToUpdate)
            {
                fight.OrderNumber--;
            }
        }
    }
}
