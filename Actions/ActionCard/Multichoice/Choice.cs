using Newtonsoft.Json;

namespace Cardyff.Actions.ActionCard.Multichoice
{
    public class Choice
    {
        [JsonProperty("display")]
        public string Display { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}