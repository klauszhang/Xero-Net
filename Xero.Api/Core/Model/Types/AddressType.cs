using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressType
    {
        [EnumMember(Value = "POBOX")]
        PostOfficeBox,
        [EnumMember(Value = "STREET")]
        Street
    }
}