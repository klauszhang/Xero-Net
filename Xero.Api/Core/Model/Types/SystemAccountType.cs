using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SystemAccountType
    {
        [EnumMember(Value = "DEBTORS")]
        Debtors,
        [EnumMember(Value = "CREDITORS")]
        Creditors,
        [EnumMember(Value = "BANKCURRENCYGAIN")]
        BankCurrencyGain,
        [EnumMember(Value = "GST")]
        GST,
        [EnumMember(Value = "GSTONIMPORTS")]
        GSTOnImports,
        [EnumMember(Value = "HISTORICAL")]
        Historical,
        [EnumMember(Value = "REALISEDCURRENCYGAIN")]
        RealisedCurrencyGain,
        [EnumMember(Value = "RETAINEDEARNINGS")]
        RetainedEarnings,
        [EnumMember(Value = "ROUNDING")]
        Rounding,
        [EnumMember(Value = "TRACKINGTRANSFERS")]
        TrackingTransfers,
        [EnumMember(Value = "UNPAIDEXPCLM")]
        UnpaidExpenseClaim,
        [EnumMember(Value = "UNREALISEDCURRENCYGAIN")]
        UnrealisedCurrencyGain,
        [EnumMember(Value = "WAGEPAYABLES")]
        WagePayables,
    } 
}
