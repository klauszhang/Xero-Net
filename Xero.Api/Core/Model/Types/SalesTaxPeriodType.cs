using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesTaxPeriodType
    {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "MONTHLY")]
        Monthly,
        [EnumMember(Value = "TWOMONTHS")]
        TwoMonths,
        [EnumMember(Value = "SIXMONTHS")]
        SixMonths,
        [EnumMember(Value = "QUARTERLY")]
        Quarterly,
        [EnumMember(Value = "QUARTERLY1")]
        QuarterlyOne,
        [EnumMember(Value = "QUARTERLY2")]
        QuarterlyTwo,
        [EnumMember(Value = "QUARTERLY3")]
        QuarterlyThree,
        [EnumMember(Value = "ANNUALLY")]
        Annually        
    }
}