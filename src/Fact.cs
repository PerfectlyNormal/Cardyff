using Newtonsoft.Json;

namespace Cardyff
{
    public class Fact
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}