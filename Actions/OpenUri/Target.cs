using Newtonsoft.Json;

namespace Cardyff.Actions.OpenUri
{
    public class Target
    {
        [JsonProperty("os")]
        public TargetOs OS { get; set; } = TargetOs.Default;
        
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}