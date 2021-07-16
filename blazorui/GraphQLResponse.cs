using System.Text.Json.Serialization;
using System.Text.Json;

namespace blazorui
{
    internal class GraphQLResponse
    {
        [JsonPropertyName("data")]
        public JsonDocument Data { get; set; }

    }
}