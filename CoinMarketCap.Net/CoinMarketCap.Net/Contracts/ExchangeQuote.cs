// -----------------------------------------------------------------------------
// <copyright file="ExchangeQuote" company="Matt Scheetz">
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
    public class ExchangeQuote
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "exchange_reported")]
        public ExchangeReport ExchangeReported { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "quote")]
        public Dictionary<string, SimpleQuote> Quote { get; set; }

        #endregion Properties
    }
}