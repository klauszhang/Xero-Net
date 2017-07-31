using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceType
    {
        [EnumMember(Value = "ACCPAY")]
        AccountsPayable,
        [EnumMember(Value = "ACCREC")]
        AccountsReceivable        
    }
}