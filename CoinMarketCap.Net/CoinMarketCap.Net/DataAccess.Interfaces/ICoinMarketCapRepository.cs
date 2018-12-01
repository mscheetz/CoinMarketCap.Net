// -----------------------------------------------------------------------------
// <copyright file="ICoinMarketCapRepository" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:07:27 PM" />
// -----------------------------------------------------------------------------

namespace CoinMarketCap.Net.DataAccess.Interfaces
{
    using CoinMarketCap.Net.Contracts;
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    #endregion Usings

    public interface ICoinMarketCapRepository
    {
        Task<Dictionary<string, Metadata>> GetMetadata(int id);

        Task<Dictionary<string, Metadata>> GetMetadata(string symbol);

        Task<Dictionary<string, Metadata>> GetMetadata(List<int> ids);

        Task<Dictionary<string, Metadata>> GetMetadata(List<string> symbols);

        Task<IEnumerable<Map>> GetIDMap();

        Task<IEnumerable<Map>> GetIDMap(ListingStatus listingStatus);

        Task<IEnumerable<Map>> GetIDMap(ListingStatus listingStatus, int start = 1, int limit = 5000);

        Task<IEnumerable<Map>> GetIDMap(int start = 1, int limit = 5000);

        Task<IEnumerable<Map>> GetIDMap(List<string> symbols);
    }
}