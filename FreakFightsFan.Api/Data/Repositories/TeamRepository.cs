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

        public IQueryable<Team> AsQueryable() 
            => _dbContext.Teams.Include(x => x.Fight)
                               .Include(x => x.Fighters)
                               .Include(x => x.TeamFighters)
                               .AsQueryable();

        public async Task<IEnumerable<Team>> GetAll() 
            => await _dbContext.Teams.Include(x => x.Fight)
                                     .Include(x => x.Fighters)
                                     .Include(x => x.TeamFighters)
                                     .ToListAsync();

        public async Task<Team> Get(int id) 
            => await _dbContext.Teams.Include(x => x.Fight)
                                     .Include(x => x.Fighters)
                                     .Include(x => x.TeamFighters)
                                     .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Team team)
        {
            await _dbContext.AddAsync(team);
            await _dbContext.SaveChangesAsync();
            return team.Id;
        }

        public Task Update(Team team)
        {
            _dbContext.Update(team);
            return Task.CompletedTask;
        }

        public Task Delete(Team team)
        {
            _dbContext.Remove(team);
            return Task.CompletedTask;
        }
    }
}
