using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrganisationType
    {
        [EnumMember(Value = "COMPANY")]
        Company,
        [EnumMember(Value = "CHARITY")]
        Charity,
        [EnumMember(Value = "CLUBSOCIETY")]
        ClubSociety,
        [EnumMember(Value = "PARTNERSHIP")]
        Partnership,
        [EnumMember(Value = "PERSON")]
        Person,
        [EnumMember(Value = "SOLETRADER")]
        SoleTrader,
        [EnumMember(Value = "TRUST")]
        Trust
    }
}