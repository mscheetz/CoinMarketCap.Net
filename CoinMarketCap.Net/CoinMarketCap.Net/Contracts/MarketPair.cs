// -----------------------------------------------------------------------------
// <copyright file="MarketPair" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:28:41 PM" />
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
    public class MarketPair
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "exchange")]
        public Exchange Exchange { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "market_pair")]
        public string Pair { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "market_pair_base")]
        public Currency MarketPairBase { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "market_pair_quote")]
        public Currency MarketPairQuote { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "quote")]
        public Dictionary<string, SimpleQuote> Quote { get; set; }

        #endregion Properties
    }
}