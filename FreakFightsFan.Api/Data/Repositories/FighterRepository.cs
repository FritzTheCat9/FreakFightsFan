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
                .AsQueryable();

        public async Task<IEnumerable<Fighter>> GetAll() => 
            await _dbContext.Fighters
                .Include(x => x.Image)
                .ToListAsync();

        public async Task<Fighter> Get(int id) => 
            await _dbContext.Fighters
                .Include(x => x.Image)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Fighter fighter)
        {
            await _dbContext.AddAsync(fighter);
            await _dbContext.SaveChangesAsync();
            return fighter.Id;
        }

        public async Task Update(Fighter fighter)
        {
            _dbContext.Update(fighter);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Fighter fighter)
        {
            _dbContext.Remove(fighter);
            await _dbContext.SaveChangesAsync();
        }
    }
}
