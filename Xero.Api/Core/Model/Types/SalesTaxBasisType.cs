using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesTaxBasisType
    {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "ACCRUAL")]
        Accural,
        [EnumMember(Value = "CASH")]
        Cash,
        [EnumMember(Value = "INVOICE")]
        Invoice,
        [EnumMember(Value = "PAYMENTS")]
        Payments,
        [EnumMember(Value = "FLATRATECASH")]
        FlatRateCash,
        [EnumMember(Value = "FLATRATEACCURAL")]
        FlatRateAccrual,
    }
}