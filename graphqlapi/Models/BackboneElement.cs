using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class BackboneElement : Element
    {
        [JsonPropertyName("modifierExtension")]
        public IList<Extension> ModifierExtensions { get; set; }
    }
}
