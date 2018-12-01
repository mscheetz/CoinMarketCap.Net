using CoinMarketCap.Net.Contracts;
using CoinMarketCap.Net.DataAccess;
using CoinMarketCap.Net.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinMarketCap.Net
{
    public class CMCClient
    {
        private readonly ICoinMarketCapRepository _repo;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Api Key (get one here: https://pro.coinmarketcap.com/)</param>
        public CMCClient(string key)
        {
            _repo = new CoinMarketCapRepository(key);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Api Key (get one here: https://pro.coinmarketcap.com/)</param>
        /// <param name="sandbox">Use sandbox?</param>
        public CMCClient(string key, bool sandbox)
        {
            _repo = new CoinMarketCapRepository(key, sandbox);
        }

        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies 
        /// including name, symbol, logo, and its various registered URLs
        /// </summary>
        /// <param name="id">Id of currency</param>
        /// <returns>Dictionary of currency metadatas</returns>
        public async Task<Dictionary<string, Metadata>> GetMetadataAsync(int id)
        {
            return await _repo.GetMetadata(id);
        }

        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies 
        /// including name, symbol, logo, and its various registered URLs
        /// </summary>
        /// <param name="symbol">Symbol of currency</param>
        /// <returns>Dictionary of currency metadatas</returns>
        public async Task<Dictionary<string, Metadata>> GetMetadataAsync(string symbol)
        {
            return await _repo.GetMetadata(symbol);
        }

        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies 
        /// including name, symbol, logo, and its various registered URLs
        /// </summary>
        /// <param name="ids">Collection of currency ids</param>
        /// <returns>Dictionary of currency metadatas</returns>
        public async Task<Dictionary<string, Metadata>> GetMetadataAsync(List<int> ids)
        {
            return await _repo.GetMetadata(ids);
        }

        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies 
        /// including name, symbol, logo, and its various registered URLs
        /// </summary>
        /// <param name="symbols">Collection of currency symbols</param>
        /// <returns>Dictionary of currency metadatas</returns>
        public async Task<Dictionary<string, Metadata>> GetMetadataAsync(List<string> symbols)
        {
            return await _repo.GetMetadata(symbols);
        }

        /// <summary>
        /// Returns a list of all cryptocurrencies by CoinMarketCap ID
        /// </summary>
        /// <returns>Collection of cryptocurrency Maps</returns>
        public async Task<IEnumerable<Map>> GetIDMapAsync()
        {
            return await _repo.GetIDMap();
        }

        /// <summary>
        /// Returns a list of all cryptocurrencies by CoinMarketCap ID
        /// </summary>
        /// <param name="listingStatus">Listing status</param>
        /// <returns>Collection of cryptocurrency Maps</returns>
        public async Task<IEnumerable<Map>> GetIDMapAsync(ListingStatus listingStatus)
        {
            return await _repo.GetIDMap(listingStatus);
        }

        /// <summary>
        /// Returns a list of all cryptocurrencies by CoinMarketCap ID
        /// </summary>
        /// <param name="listingStatus">Listing status</param>
        /// <param name="start">Starting record number</param>
        /// <param name="limit">Number of records per page</param>
        /// <returns>Collection of cryptocurrency Maps</returns>
        public async Task<IEnumerable<Map>> GetIDMapAsync(ListingStatus listingStatus, int start = 1, int limit = 5000)
        {
            return await _repo.GetIDMap(listingStatus, start, limit);
        }

        /// <summary>
        /// Returns a list of all cryptocurrencies by CoinMarketCap ID
        /// </summary>
        /// <param name="start">Starting record number</param>
        /// <param name="limit">Number of records per page</param>
        /// <returns>Collection of cryptocurrency Maps</returns>
        public async Task<IEnumerable<Map>> GetIDMapAsync(int start = 1, int limit = 5000)
        {
            return await _repo.GetIDMap(start, limit);
        }

        /// <summary>
        /// Returns a list of all cryptocurrencies by CoinMarketCap ID
        /// </summary>
        /// <param name="symbols">Collection of symbols to find</param>
        /// <returns>Collection of cryptocurrency Maps</returns>
        public async Task<IEnumerable<Map>> GetIDMapAsync(List<string> symbols)
        {
            return await _repo.GetIDMap(symbols);
        }
    }
}
