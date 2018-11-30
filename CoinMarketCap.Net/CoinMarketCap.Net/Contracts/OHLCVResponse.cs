// -----------------------------------------------------------------------------
// <copyright file="OHLCVResponse" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:45:43 PM" />
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
    public class OHLCVResponse
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "quotes")]
        public OHLCVQuote[] Quotes { get; set; }

        #endregion Properties
    }
}