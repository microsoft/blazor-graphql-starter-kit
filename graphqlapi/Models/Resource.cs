using System;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("implicitRules")]
        public Uri ImplicitRules { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }
    }
}
