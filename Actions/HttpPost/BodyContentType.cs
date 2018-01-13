using System.Runtime.Serialization;

namespace Cardyff.Actions.HttpPost
{
    public enum BodyContentType
    {
        [EnumMember(Value = "application/json")] 
        Json,
        [EnumMember(Value = "application/x-www-form-urlencoded")]
        FormEncoded
    }
}