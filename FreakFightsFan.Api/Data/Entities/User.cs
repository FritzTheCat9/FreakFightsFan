using FreakFightsFan.Shared.Features.Users.Helpers;

namespace FreakFightsFan.Api.Data.Entities
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool EmailConfirmed { get; set; }
        public string EmailConfirmationToken { get; set; }
        public string RefreshToken { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }
        public ThemeColor ThemeColor { get; set; }
    }
}
