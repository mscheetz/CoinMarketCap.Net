// -----------------------------------------------------------------------------
// <copyright file="ResponseWrapper" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:08:52 PM" />
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
    public class ResponseWrapper<T>
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "data")]
        public T Data { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "status")]
        public ResponseStatus Status { get; set; }

        #endregion Properties
    }
}