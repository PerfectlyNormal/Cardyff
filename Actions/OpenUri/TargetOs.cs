using System.Runtime.Serialization;

namespace Cardyff.Actions.OpenUri
{
    public enum TargetOs
    {
        [EnumMember(Value = "default")]
        Default,
        
        [EnumMember(Value = "windows")]
        Windows,
        
        [EnumMember(Value = "iOS")]
        iOS,
        
        [EnumMember(Value = "android")]
        Android,
    }
}