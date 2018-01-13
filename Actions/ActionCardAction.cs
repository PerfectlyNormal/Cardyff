using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cardyff.Actions
{
    public class ActionCardAction : BaseAction
    {
        [JsonProperty("inputs")]
        public IEnumerable<ActionCard.Input> Inputs { get; set; }
        
        [JsonProperty("actions")]
        public IEnumerable<IEmbeddableAction> Actions { get; set; }
    }
}