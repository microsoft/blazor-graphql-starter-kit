using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class DomainResource : Resource
    {
        [JsonPropertyName("text")]
        public Narrative Text { get; set; }

        [JsonPropertyName("contained")]
        public Resource Contained { get; set; }

        [JsonPropertyName("extension")]
        public Extension Extension { get; set; }

        [JsonPropertyName("modifierExtension")]
        public Extension ModifierExtension { get; set; }
    }
}
