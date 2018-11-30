// -----------------------------------------------------------------------------
// <copyright file="Listing" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:20:01 PM" />
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
    public class Listing
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "name")]
        public int Name { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "symbol")]
        public int Symbol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "slug")]
        public int Slug { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "cmc_rank")]
        public int CMC_Rank { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "num_market_pairs")]
        public int NumMarketPairs { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "circulating_supply")]
        public int CirculatingSupply { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "total_supply")]
        public int TotalSupply { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "max_supply")]
        public int MaxSupply { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "last_update")]
        public DateTimeOffset LastUpdated { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "quote")]
        public Dictionary<string, Quote> Quote { get; set; }



        #endregion Properties
    }
}