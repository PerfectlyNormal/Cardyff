using Cardyff.Actions;
using Newtonsoft.Json;

namespace Cardyff
{
    public class BaseAction : IAction
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}