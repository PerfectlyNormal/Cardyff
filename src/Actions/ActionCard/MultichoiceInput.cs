using System.Collections.Generic;
using Cardyff.Actions.ActionCard.Multichoice;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cardyff.Actions.ActionCard
{
    public class MultichoiceInput : Input
    {
        /// <summary>
        /// Defines the values that can be selected for the multichoice input.
        /// </summary>
        [JsonProperty("choices")]
        public IEnumerable<Choice> Choices { get; set; }

        /// <summary>
        /// If set to true, indicates that the user can select more than one
        /// choice. The specified choices will be displayed as a list of
        /// checkboxes.
        /// 
        /// Default value is false.
        /// </summary>
        [JsonProperty("isMultiSelect")]
        public bool MultiSelect { get; set; } = false;

        [JsonProperty("style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Style Style { get; set; } = Style.Normal;
    }
}