using System;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Meta : Element
    {
        [JsonPropertyName("versionId")]
        public string VersionId { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("source")]
        public Uri Source { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }
    }
}
