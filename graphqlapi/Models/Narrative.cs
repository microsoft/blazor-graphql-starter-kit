using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class Narrative : Element
    {
        [JsonPropertyName("status")]
        public NarrativeStatus Status { get; set; }

        [JsonPropertyName("div")]
        public string Div { get; set; }
    }
}
