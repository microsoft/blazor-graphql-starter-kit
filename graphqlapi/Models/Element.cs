using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace graphqlapi.Models
{
    public class Element
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("extension")]
        public IList<Extension> Extensions { get; set; }
    }
}
