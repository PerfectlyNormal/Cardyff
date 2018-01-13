using System.Collections.Generic;
using Cardyff.Actions;
using Newtonsoft.Json;

namespace Cardyff
{
    public class MessageCard
    {
        [JsonProperty("@type")]
        public const string Type = "MessageCard";
        
        [JsonProperty("@context")]
        public const string Context = "http://schema.org/extensions";
        
        [JsonProperty("summary")]
        public string Summary { get; set; }
        
        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("sections")]
        public IEnumerable<Section> Sections { get; set; }
        
        [JsonProperty("potentialAction")]
        public IEnumerable<IAction> Actions { get; set; }
    }
}