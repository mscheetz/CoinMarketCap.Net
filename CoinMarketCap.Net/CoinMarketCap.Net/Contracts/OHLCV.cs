// -----------------------------------------------------------------------------
// <copyright file="OHLCV" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:42:06 PM" />
// -----------------------------------------------------------------------------

namespace CoinMarketCap.Net.Contracts
{
    using Newtonsoft.Json;
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;

    #endregion Usings

    [DataContract]
    [Serializable]
    public class OHLCV
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "open")]
        public decimal Open { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "high")]
        public decimal High { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "low")]
        public decimal Low { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "close")]
        public decimal Close { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        #endregion Properties
    }
}