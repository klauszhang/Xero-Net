using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentType
    {
        [EnumMember(Value = "ACCPAYPAYMENT")]
        AccountsPayable,
        [EnumMember(Value = "ACCRECPAYMENT")]
        AccountsReceivable,
        [EnumMember(Value = "APCREDITPAYMENT")]
        AccountsPayableCredit,
        [EnumMember(Value = "ARCREDITPAYMENT")]
        AccountsReceivableCredit,
        [EnumMember(Value = "ARPREPAYMENTPAYMENT")]
        AccountsReceivablePrepayment,
        [EnumMember(Value = "APPREPAYMENTPAYMENT")]
        AccountsPayablePrepayment,
        [EnumMember(Value = "AROVERPAYMENTPAYMENT")]
        AccountsReceivableOverpayment,
        [EnumMember(Value = "APOVERPAYMENTPAYMENT")]
        AccountsPayableOverpayment,
    }
}
