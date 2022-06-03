using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace blazorui
{
    internal class GraphQLRequest
    {
        private readonly HttpClient _httpClient;

        [JsonPropertyName("OperationName")]
        public string OperationName { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("variables")]
        public Dictionary<string, object> Variables { get; set; }

        public GraphQLRequest(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<JsonDocument> PostAsync()
        {
            var query = new StringContent(
                JsonSerializer.Serialize(this),
                Encoding.UTF8,
                "application/json");
            JsonDocument data = null;
            try
            {
                var response = await _httpClient.PostAsync("graphql", query);
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    var gq = await JsonSerializer.DeserializeAsync<GraphQLResponse>(stream);
                    data = gq.Data;
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