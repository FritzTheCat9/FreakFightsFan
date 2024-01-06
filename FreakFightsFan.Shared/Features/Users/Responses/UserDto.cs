namespace FreakFightsFan.Shared.Features.Users.Responses
{
    public class UserDto
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
