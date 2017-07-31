using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ObjectGroupType
    {
        [EnumMember(Value = "Account")]
        Account,
        [EnumMember(Value = "BankTransaction")]
        BankTransaction,
        [EnumMember(Value = "Contact")]
        Contact,
        [EnumMember(Value = "CreditNote")]
        CreditNote,
        [EnumMember(Value = "FixedAssets")]
        FixedAssets,
        [EnumMember(Value = "Invoice")]
        Invoice,
        [EnumMember(Value = "Item")]
        Item,
        [EnumMember(Value = "ManualJournal")]
        ManualJournal,
        [EnumMember(Value = "Overpayment")]
        Overpayment,
        [EnumMember(Value = "Payment")]
        Payment,
        [EnumMember(Value = "Payrun")]
        Payrun,
        [EnumMember(Value = "Prepayment")]
        Prepayment,
        [EnumMember(Value = "PurchaseOrder")]
        PurchaseOrder,
        [EnumMember(Value = "Receipt")]
        Receipt,
        [EnumMember(Value = "Reconciliation")]
        Reconciliation
    }
}
