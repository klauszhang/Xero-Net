using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportTaxType
    {
        [EnumMember(Value = "OUTPUT")]
        Output,
        [EnumMember(Value = "INPUT")]
        Input,
        [EnumMember(Value = "EXEMPTOUTPUT")]
        ExemptOutput,
        [EnumMember(Value = "EXEMPTINPUT")]
        ExemptInput,
        [EnumMember(Value = "INPUTTAXED")]
        InputTaxed,
        [EnumMember(Value = "BASEXCLUDED")]
        BasExcluded,
        [EnumMember(Value = "EXEMPTEXPENSES")]
        ExemptExpenses,
        [EnumMember(Value = "ECOUTPUT")]
        EcOutput,
        [EnumMember(Value = "ECOUTPUTSERVICES")]
        EcOutputServices,
        [EnumMember(Value = "ECINPUT")]
        EcInput,
        [EnumMember(Value = "CAPITALSALESOUTPUT")]
        CapitalSalesOutput,
        [EnumMember(Value = "CAPITALEXPENSESINPUT")]
        CapitalExpensesInput
    }
}