using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace blazorui
{
    public class GraphQLAPIClient
    {
        private readonly HttpClient _httpClient;

        public GraphQLAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<JsonContent> PostAsync()
        {
            var query = new StringContent(
                JsonSerializer.Serialize(this),
                Encoding.UTF8,
                "application/json");
            JsonContent data = null;
            try
            {
                var response = await _httpClient.PostAsync("graphql", query);
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    data = await JsonSerializer.DeserializeAsync<JsonContent>(stream);
                }
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
             return data;
        }
    }
}