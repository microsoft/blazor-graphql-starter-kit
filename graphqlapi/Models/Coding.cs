using System;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Coding
    {
        [JsonPropertyName("system")]
        public Uri System { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("display")]
        public string Display { get; set; }

        [JsonPropertyName("userSelected")]
        public bool UserSelected { get; set; }
    }
}
