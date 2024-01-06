using FreakFightsFan.Api.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace FreakFightsFan.Api.Auth
{
    public interface IPasswordService
    {
        string Hash(string password);
        bool Validate(string password, string hashedPassword);
    }

    public class PasswordService : IPasswordService
    {
        private readonly IPasswordHasher<User> _passwordHasher;

        public PasswordService(IPasswordHasher<User> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public string Hash(string password)
            => _passwordHasher.HashPassword(default, password);

        public bool Validate(string password, string hashedPassword)
            => _passwordHasher.VerifyHashedPassword(default, hashedPassword, password) is PasswordVerificationResult.Success;
    }
}
