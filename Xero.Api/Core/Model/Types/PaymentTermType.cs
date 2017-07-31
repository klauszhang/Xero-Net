using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentTermType
    {
        [EnumMember(Value = "OFFOLLOWINGMONTH")]
        FollowingMonth,
        [EnumMember(Value = "DAYSAFTERBILLDATE")]
        AfterBillDate,
        [EnumMember(Value = "OFCURRENTMONTH")]
        CurrentMonth,
        [EnumMember(Value = "DAYSAFTERBILLMONTH")]
        DaysAfterBillMonth,
        [EnumMember(Value = "DAYSAFTERINVOICEMONTH")]
        AfterInvoiceMonth
    }
}