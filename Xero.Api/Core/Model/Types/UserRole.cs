using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserRole
    {
        [EnumMember(Value = "READONLY")]
        ReadOnly,
        [EnumMember(Value = "INVOICEONLY")]
        InvoiceOnly,
        [EnumMember(Value = "STANDARD")]
        Standard,
        [EnumMember(Value = "FINANCIALADVISER")]
        FinancialAdviser,
        [EnumMember(Value = "MANAGEDCLIENT")]
        ManagedClient,
        [EnumMember(Value = "CASHBOOKCLIENT")]
        CashBookClient
    }
}