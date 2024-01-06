using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IFederationRepository
    {
        IQueryable<Federation> AsQueryable();
        Task<IEnumerable<Federation>> GetAll();
        Task<Federation> Get(int id);
        Task<int> Create(Federation federation);
        Task Update(Federation federation);
        Task Delete(Federation federation);
    }

    public class FederationRepository : IFederationRepository
    {
        private readonly AppDbContext _dbContext;

        public FederationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Federation> AsQueryable() =>
            _dbContext.Federations
                .Include(x => x.Events)
                .Include(x => x.Image)
                .AsQueryable();

        public async Task<IEnumerable<Federation>> GetAll() => 
            await _dbContext.Federations
                .Include(x => x.Events)
                .Include(x => x.Image)
                .ToListAsync();

        public async Task<Federation> Get(int id) => 
            await _dbContext.Federations
                .Include(x => x.Events)
                .Include(x => x.Image)
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Federation federation)
        {
            await _dbContext.AddAsync(federation);
            await _dbContext.SaveChangesAsync();
            return federation.Id;
        }

        public Task Update(Federation federation)
        {
            _dbContext.Update(federation);
            return Task.CompletedTask;
        }

        public Task Delete(Federation federation)
        {
            _dbContext.Remove(federation);
            return Task.CompletedTask;
        }
    }
}
