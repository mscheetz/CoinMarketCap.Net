// -----------------------------------------------------------------------------
// <copyright file="LatestListing" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:23:13 PM" />
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
    public class LatestListing : Listing
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "date_added")]
        public DateTimeOffset DateAdded { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "tags")]
        public string[] tags { get; set; }

        #endregion Properties
    }
}