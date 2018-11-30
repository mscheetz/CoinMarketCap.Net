// -----------------------------------------------------------------------------
// <copyright file="Currency" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:25:55 PM" />
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
    public class Currency
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "currency_id")]
        public int CurrencyId { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "currency_symbol")]
        public string CurrencySymbol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "currency_type")]
        public string CurrencyType { get; set; }

        #endregion Properties
    }
}