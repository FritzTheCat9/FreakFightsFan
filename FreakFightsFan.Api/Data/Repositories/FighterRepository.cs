using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IFighterRepository
    {
        IQueryable<Fighter> AsQueryable();
        Task<IEnumerable<Fighter>> GetAll();
        Task<Fighter> Get(int id);
        Task<int> Create(Fighter fighter);
        Task Update(Fighter fighter);
        Task Delete(Fighter fighter);
        Task SaveChanges();
    }

    public class FighterRepository : IFighterRepository
    {
        private readonly AppDbContext _dbContext;

        public FighterRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Fighter> AsQueryable() => 
            _dbContext.Fighters
                .Include(x => x.Image)
                .Include(x => x.Teams)
                .Include(x => x.TeamFighters)
                .AsQueryable();

        public async Task<IEnumerable<Fighter>> GetAll() => 
            await _dbContext.Fighters
                .Include(x => x.Image)
                .Include(x => x.Teams)
                .Include(x => x.TeamFighters)
                .ToListAsync();

        public async Task<Fighter> Get(int id) => 
            await _dbContext.Fighters
                .Include(x => x.Image)
                .Include(x => x.Teams)
                .Include(x => x.TeamFighters)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Fighter fighter)
        {
            await _dbContext.AddAsync(fighter);
            return fighter.Id;
        }

        public Task Update(Fighter fighter)
        {
            _dbContext.Update(fighter);
            return Task.CompletedTask;
        }

        public Task Delete(Fighter fighter)
        {
            _dbContext.Remove(fighter);
            return Task.CompletedTask;
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
