// -----------------------------------------------------------------------------
// <copyright file="OHLCVQuote" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:44:27 PM" />
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
    public class OHLCVQuote
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "time_open")]
        public DateTimeOffset TimeOpen { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "time_close")]
        public DateTimeOffset TimeClose { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "quote")]
        public Dictionary<string, OHLCV> Quote { get; set; }

        #endregion Properties
    }
}