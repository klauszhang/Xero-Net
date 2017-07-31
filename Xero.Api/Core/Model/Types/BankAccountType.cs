using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    [DataContract(Namespace = "")]
    public enum BankAccountType
    {
        [EnumMember(Value = "BANK")]
        Bank,
        [EnumMember(Value = "CREDITCARD")]
        CreditCard,
        [EnumMember(Value = "PAYPAL")]
        Paypal,
    }
}
