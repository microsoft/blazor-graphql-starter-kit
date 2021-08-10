using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace graphqlapi.Models
{
    public class QuestionnaireItem : BackboneElement
    {
        [JsonPropertyName("linkId")]
        public string LinkId { get; set; }

        [JsonPropertyName("definition")]
        public Uri Definition { get; set; }

        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("required")]
        public bool Required { get; set; }

        [JsonPropertyName("repeats")]
        public bool Repeats { get; set; }

        [JsonPropertyName("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonPropertyName("maxLength")]
        public int MaxLength { get; set; }

        [JsonPropertyName("item")]
        public IList<QuestionnaireItem> Items { get; set; }
    }
}
