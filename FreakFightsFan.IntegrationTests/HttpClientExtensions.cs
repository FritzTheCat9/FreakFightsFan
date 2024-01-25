using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Responses;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using static FreakFightsFan.IntegrationTests.TestUsers;

namespace FreakFightsFan.IntegrationTests
{
    public static class HttpClientExtensions
    {
        public static async Task Login(this HttpClient client, UserBase user)
        {
            var token = await GetJwtForUser(client, user);
            client.DefaultRequestHeaders.Authorization = token is not null ? new AuthenticationHeaderValue("Bearer", token.AccessToken) : null;
        }

        public static async Task LoginAsUserAsync(this HttpClient client)
        {
            var token = await GetJwtForUser(client, new User());
            client.DefaultRequestHeaders.Authorization = token is not null ? new AuthenticationHeaderValue("Bearer", token.AccessToken) : null;
        }

        public static async Task LoginAsAdminAsync(this HttpClient client)
        {
            var token = await GetJwtForUser(client, new Admin());
            client.DefaultRequestHeaders.Authorization = token is not null ? new AuthenticationHeaderValue("Bearer", token.AccessToken) : null;
        }

        public static async Task LoginAsSuperAdminAsync(this HttpClient client)
        {
            var token = await GetJwtForUser(client, new SuperAdmin());
            client.DefaultRequestHeaders.Authorization = token is not null ? new AuthenticationHeaderValue("Bearer", token.AccessToken) : null;
        }

        public static void Logout(this HttpClient client)
        {
            client.DefaultRequestHeaders.Authorization = null;
        }

        private static async Task<JwtDto> GetJwtForUser(HttpClient client, UserBase user)
        {
            var command = new Login.Command
            {
                Email = user.Email,
                Password = user.Password,
            };

            var response = await client.PostAsJsonAsync("api/users/login", command);
            var jwt = await response.Content.ReadFromJsonAsync<JwtDto>();

            return jwt;
        }
    }
}
