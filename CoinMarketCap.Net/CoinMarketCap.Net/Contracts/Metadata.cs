// -----------------------------------------------------------------------------
// <copyright file="Metadata" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:48:11 PM" />
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
    public class Metadata : CurrencyBase
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "logo")]
        public int Logo { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "tags")]
        public string[] Tags { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "urls")]
        public Dictionary<string, string[]> Urls { get; set; }

        #endregion Properties
    }
}