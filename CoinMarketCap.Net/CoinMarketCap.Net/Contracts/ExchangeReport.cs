// -----------------------------------------------------------------------------
// <copyright file="ExchangeReport" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:27:14 PM" />
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
    public class ExchangeReport
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "volume_24h_base")]
        public decimal Volume24hBase { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "volume_24h_quote")]
        public decimal Volume24hQuote { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        #endregion Properties
    }
}