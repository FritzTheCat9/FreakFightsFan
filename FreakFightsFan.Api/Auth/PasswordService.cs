using FreakFightsFan.Api.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace FreakFightsFan.Api.Auth;

public interface IPasswordService
{
    string Hash(string password);
    bool Validate(string password, string hashedPassword);
}

public class PasswordService(IPasswordHasher<User> passwordHasher) : IPasswordService
{
    public string Hash(string password)
    {
        return passwordHasher.HashPassword(default!, password);
    }

    public bool Validate(string password, string hashedPassword)
    {
        return passwordHasher.VerifyHashedPassword(default!, hashedPassword, password)
            is PasswordVerificationResult.Success;
    }
}