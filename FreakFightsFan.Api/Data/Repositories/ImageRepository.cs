using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories
{
    public interface IImageRepository
    {
        IQueryable<Image> AsQueryable();
        Task<IEnumerable<Image>> GetAll();
        Task<Image> Get(int id);
        Task<int> Create(Image image);
        Task Update(Image image);
        Task Delete(Image image);
    }

    public class ImageRepository : IImageRepository
    {
        private readonly AppDbContext _dbContext;

        public ImageRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Image> AsQueryable() 
            => _dbContext.Images.Include(x => x.Federation)
                                .Include(x => x.Fighter)
                                .AsSplitQuery()
                                .AsQueryable();

        public async Task<IEnumerable<Image>> GetAll() 
            => await _dbContext.Images.Include(x => x.Federation)
                                      .Include(x => x.Fighter)
                                      .AsSplitQuery()
                                      .ToListAsync();

        public async Task<Image> Get(int id) 
            => await _dbContext.Images.Include(x => x.Federation)
                                      .Include(x => x.Fighter)
                                      .AsSplitQuery()
                                      .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<int> Create(Image image)
        {
            await _dbContext.AddAsync(image);
            await _dbContext.SaveChangesAsync();
            return image.Id;
        }

        public Task Update(Image image)
        {
            _dbContext.Update(image);
            return Task.CompletedTask;
        }

        public Task Delete(Image image)
        {
            _dbContext.Remove(image);
            return Task.CompletedTask;
        }
    }
}
