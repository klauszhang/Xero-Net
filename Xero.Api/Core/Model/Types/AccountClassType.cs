using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]

    public enum AccountClassType
    {
        [EnumMember(Value = "ASSET")]
        Asset,
        [EnumMember(Value = "EQUITY")]
        Equity,
        [EnumMember(Value = "EXPENSE")]
        Expense,
        [EnumMember(Value = "LIABILITY")]
        Liability,
        [EnumMember(Value = "REVENUE")]
        Revenue,
    }
}
