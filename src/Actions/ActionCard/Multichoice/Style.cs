using System.Runtime.Serialization;

namespace Cardyff.Actions.ActionCard.Multichoice
{
    public enum Style
    {
        [EnumMember(Value = "normal")]
        Normal,
        
        [EnumMember(Value = "expanded")]
        Expanded
    }
}