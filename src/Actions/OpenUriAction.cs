using System.Collections.Generic;
using Cardyff.Actions.OpenUri;
using Newtonsoft.Json;

namespace Cardyff.Actions
{
    public class OpenUriAction : BaseAction, IEmbeddableAction
    {
        [JsonProperty("targets")]
        public IEnumerable<Target> Targets { get; set; }
    }
}