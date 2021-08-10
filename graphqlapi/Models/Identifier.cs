using System;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Identifier : Element
    {
        [JsonPropertyName("use")]
        public IdentifierUse Use { get; set; }

        [JsonPropertyName("type")]
        public IdentifierType Type { get; set; }

        [JsonPropertyName("system")]
        public Uri System { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("period")]
        public Period Period { get; set; }
    }
}
