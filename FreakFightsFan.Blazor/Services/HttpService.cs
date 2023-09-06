using FreakFightsFan.Shared.Exceptions;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace FreakFightsFan.Blazor.Services
{
    public interface IHttpService
    {
        Task<TResponse> Get<TResponse>(string url);
        Task Post<TRequest>(string url, TRequest tRequest);
        Task<TResponse> Post<TRequest, TResponse>(string url, TRequest tRequest);
        Task Put<TRequest>(string url, TRequest tRequest);
        Task Delete(string url);
    }

    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public HttpService(HttpClient client)
        {
            _client = client;
            _baseUrl = client.BaseAddress.ToString();
        }

        public async Task<TResponse> Get<TResponse>(string url)
        {
            var response = await _client.GetAsync(_baseUrl + url);

            if (!response.IsSuccessStatusCode)
                await HandleErrors(response);

            var tResponse = await response.Content.ReadFromJsonAsync<TResponse>();
            return tResponse;
        }

        public async Task Post<TRequest>(string url, TRequest tRequest)
        {
            var response = await _client.PostAsJsonAsync(_baseUrl + url, tRequest);

            if (!response.IsSuccessStatusCode)
                await HandleErrors(response);
        }

        public async Task<TResponse> Post<TRequest, TResponse>(string url, TRequest tRequest)
        {
            var response = await _client.PostAsJsonAsync(_baseUrl + url, tRequest);

            if (!response.IsSuccessStatusCode)
                await HandleErrors(response);

            var tResponse = await response.Content.ReadFromJsonAsync<TResponse>();
            return tResponse;
        }

        public async Task Put<TRequest>(string url, TRequest tRequest)
        {
            var response = await _client.PutAsJsonAsync(_baseUrl + url, tRequest);

            if (!response.IsSuccessStatusCode)
                await HandleErrors(response);
        }

        public async Task Delete(string url)
        {
            var response = await _client.DeleteAsync(_baseUrl + url);

            if (!response.IsSuccessStatusCode)
                await HandleErrors(response);
        }

        private static async Task HandleErrors(HttpResponseMessage response)
        {
            var error = await response.Content.ReadAsStringAsync();
            var tResponse = JsonConvert.DeserializeObject<ErrorResponse>(error);

            switch (tResponse.Type)
            {
                case ExceptionType.Validation:
                    var validationErrorResponse = JsonConvert.DeserializeObject<ValidationErrorResponse>(error);
                    throw new MyValidationException(validationErrorResponse.Errors);
                case ExceptionType.Unauthorized:
                    var unauthorizedErrorResponse = JsonConvert.DeserializeObject<UnauthorizedErrorResponse>(error);
                    throw new MyUnauthorizedException();
                case ExceptionType.Forbidden:
                    var forbiddenErrorResponse = JsonConvert.DeserializeObject<ForbiddenErrorResponse>(error);
                    throw new MyForbiddenException();
                case ExceptionType.NotFound:
                    var notFoundErrorResponse = JsonConvert.DeserializeObject<NotFoundErrorResponse>(error);
                    throw new MyNotFoundException();
                case ExceptionType.Server:
                default:
                    var serverErrorResponse = JsonConvert.DeserializeObject<ServerErrorResponse>(error);
                    throw new MyServerException();
            }
        }
    }
}
