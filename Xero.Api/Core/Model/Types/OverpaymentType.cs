using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OverpaymentType
    {
        [EnumMember(Value = "SPEND-OVERPAYMENT")]
        SpendOverpayment,
        [EnumMember(Value = "RECEIVE-OVERPAYMENT")]
        ReceiveOverpayment
    }
}