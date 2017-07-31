using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]

    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BankTransactionType
    {
        [EnumMember(Value = "RECEIVE")]
        Receive,
        [EnumMember(Value = "SPEND")]
        Spend,
        [EnumMember(Value = "RECEIVE-OVERPAYMENT")]
        ReceiveOverpayment,
        [EnumMember(Value = "RECEIVE-PREPAYMENT")]
        ReceivePrepayment,
        [EnumMember(Value = "RECEIVE-TRANSFER")]
        ReceiveTransfer,
        [EnumMember(Value = "SPEND-OVERPAYMENT")]
        SpendOverpayment,
        [EnumMember(Value = "SPEND-PREPAYMENT")]
        SpendPrepayment,
        [EnumMember(Value = "SPEND-TRANSFER")]
        SpendTransfer
    }
}
