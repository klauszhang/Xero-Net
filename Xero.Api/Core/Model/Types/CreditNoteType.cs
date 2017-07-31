using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreditNoteType
    {
        [EnumMember(Value = "ACCPAYCREDIT")]
        AccountsPayable,
        [EnumMember(Value = "ACCRECCREDIT")]
        AccountsReceivable        
    }
}