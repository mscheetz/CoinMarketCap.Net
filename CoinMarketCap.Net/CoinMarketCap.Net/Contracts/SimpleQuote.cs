// -----------------------------------------------------------------------------
// <copyright file="SimpleQuote" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:18:09 PM" />
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
    public class SimpleQuote
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "volume_24h")]
        public decimal Volume24h { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        #endregion Properties
    }
}