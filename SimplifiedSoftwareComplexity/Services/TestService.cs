using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;
//using Microsoft.Net.Http.Headers;

namespace SimplifiedSoftwareComplexity.Services
{
    public class TestService : IService
    {
        /* _httpClient.DefaultRequestHeaders.Add(
            HeaderNames.Accept, "application/vnd.github.v3+json");
        _httpClient.DefaultRequestHeaders.Add(
            HeaderNames.UserAgent, "HttpRequestsSample");
        */

        // working code
        /*

        private HttpRequestMessage httpRequestMessage;
        private string URL;
        private readonly HttpClient _httpClient;

        public TestService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://api.github.com/");

            // using Microsoft.Net.Http.Headers;
            // The GitHub API requires two headers.
            _httpClient.DefaultRequestHeaders.Add(
                HeaderNames.Accept, "application/vnd.github.v3+json");
            _httpClient.DefaultRequestHeaders.Add(
                HeaderNames.UserAgent, "HttpRequestsSample");
        }

        public HttpResponseMessage HttpClientGet()
        {
            HttpResponseMessage result = _httpClient.Send(httpRequestMessage);
            return result;
        }
        */
    }
}
