// -----------------------------------------------------------------------------
// <copyright file="CurrencyBase" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:12:12 PM" />
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
    public class CurrencyBase
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

        #endregion Properties
    }
}