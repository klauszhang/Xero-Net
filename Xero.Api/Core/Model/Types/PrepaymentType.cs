﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PrepaymentType
    {
        [EnumMember(Value = "SPEND-PREPAYMENT")]
        SpendPrepayment,
        [EnumMember(Value = "RECEIVE-PREPAYMENT")]
        ReceivePrepayment
    }
}