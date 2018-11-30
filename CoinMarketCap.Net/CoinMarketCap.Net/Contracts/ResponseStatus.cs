// -----------------------------------------------------------------------------
// <copyright file="ResponseStatus" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:10:06 PM" />
// -----------------------------------------------------------------------------

namespace CoinMarketCap.Net.Contracts
{
    #region Usings

    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;

    #endregion Usings

    [DataContract]
    [Serializable]
    public class ResponseStatus
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "error_code")]
        public int ErrorCode { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "elapsed")]
        public int Elapsed { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "credit_count")]
        public int CreditCount { get; set; }

        #endregion Properties
    }
}