// -----------------------------------------------------------------------------
// <copyright file="Map" company="Matt Scheetz">
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
    public class Map : CurrencyBase
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "is_active")]
        public bool IsActive { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "first_historical_data")]
        public DateTimeOffset FirstHistoricalData { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "last_historical_data")]
        public DateTimeOffset LastHistoricalData { get; set; }

        #endregion Properties
    }
}