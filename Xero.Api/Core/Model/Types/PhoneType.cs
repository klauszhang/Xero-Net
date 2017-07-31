using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneType
    {
        [EnumMember(Value="DEFAULT")]
        Default,
        [EnumMember(Value = "DDI")]
        DirectDial,
        [EnumMember(Value = "MOBILE")]
        Mobile,
        [EnumMember(Value = "FAX")]
        Fax        
    }
}