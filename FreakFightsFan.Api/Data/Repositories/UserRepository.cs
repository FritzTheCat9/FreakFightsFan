using FreakFightsFan.Api.Data.Database;
using FreakFightsFan.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakFightsFan.Api.Data.Repositories;

public interface IUserRepository
{
    IQueryable<User> AsQueryable();
    Task<IEnumerable<User>> GetAll();
    Task<User> Get(int id);
    Task<User> GetByEmail(string email);
    Task<User> GetByUserName(string userName);
    Task<bool> EmailExists(string email);
    Task<bool> UserNameExists(string userName);
    Task<bool> IsTokenAssignedToUser(string email, string token);
    Task<int> Create(User user);
    Task Update(User user);
    Task Delete(User user);
}

public class UserRepository(AppDbContext dbContext) : IUserRepository
{
    public IQueryable<User> AsQueryable()
    {
        return dbContext.Users.AsQueryable();
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return await dbContext.Users.ToListAsync();
    }

    public async Task<User> Get(int id)
    {
        return await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User> GetByEmail(string email)
    {
        return await dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task<User> GetByUserName(string userName)
    {
        return await dbContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
    }

    public async Task<bool> EmailExists(string email)
    {
        return await dbContext.Users.AnyAsync(x => x.Email == email);
    }

    public async Task<bool> UserNameExists(string userName)
    {
        return await dbContext.Users.AnyAsync(x => x.UserName == userName);
    }

    public async Task<bool> IsTokenAssignedToUser(string email, string token)
    {
        return await dbContext.Users.AnyAsync(x => x.Email == email
                                                   && x.EmailConfirmationToken == token);
    }

    public async Task<int> Create(User user)
    {
        await dbContext.AddAsync(user);
        await dbContext.SaveChangesAsync();
        return user.Id;
    }

    public async Task Update(User user)
    {
        dbContext.Update(user);
        await dbContext.SaveChangesAsync();
    }

    public Task Delete(User user)
    {
        dbContext.Remove(user);
        return Task.CompletedTask;
    }
}