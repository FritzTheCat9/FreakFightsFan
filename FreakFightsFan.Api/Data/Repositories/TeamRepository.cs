using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface ITeamRepository
    {
        IQueryable<Team> AsQueryable();
        Task<IEnumerable<Team>> GetAll();
        Task<Team> Get(int id);
        Task<int> Create(Team team);
        Task Update(Team team);
        Task Delete(Team team);
    }

    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _dbContext;

        public TeamRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Team> AsQueryable() => _dbContext.Teams.AsQueryable();

        public async Task<IEnumerable<Team>> GetAll() => await _dbContext.Teams.ToListAsync();

        public async Task<Team> Get(int id) => await _dbContext.Teams.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Team team)
        {
            await _dbContext.AddAsync(team);
            await _dbContext.SaveChangesAsync();
            return team.Id;
        }

        public async Task Update(Team team)
        {
            _dbContext.Update(team);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Team team)
        {
            _dbContext.Remove(team);
            await _dbContext.SaveChangesAsync();
        }
    }
}
