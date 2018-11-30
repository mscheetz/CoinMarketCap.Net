// -----------------------------------------------------------------------------
// <copyright file="CoinMarketCapRepository" company="Matt Scheetz">
//     Copyright (c) Matt Scheetz All Rights Reserved
// </copyright>
// <author name="Matt Scheetz" date="11/29/2018 9:07:19 PM" />
// -----------------------------------------------------------------------------

namespace CoinMarketCap.Net.DataAccess
{
    using CoinMarketCap.Net.Contracts;
    using CoinMarketCap.Net.DataAccess.Interfaces;
    using RESTApiAccess;
    using RESTApiAccess.Interface;
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion Usings

    public class CoinMarketCapRepository : ICoinMarketCapRepository
    {
        #region Properties

        private readonly IRESTRepository rest;
        private string apiKey;
        private bool sandbox;
        private string baseUrl;

        #endregion Properties

        public CoinMarketCapRepository(string key, bool sandbox = false)
        {
            apiKey = key;
            var apiRoot = sandbox ? "sandbox" : "pro";
            baseUrl = $"https://{apiRoot}-api.coinmarketcap.com";

            rest = new RESTRepository();
        }

        public async Task<Dictionary<string, Metadata>> GetMetadata(int id)
        {
            var ids = new List<int> { id };

            return await OnGetMetadata(ids, new List<string>());
        }

        public async Task<Dictionary<string, Metadata>> GetMetadata(string symbol)
        {
            var symbols = new List<string> { symbol };

            return await OnGetMetadata(new List<int>(), symbols);
        }

        public async Task<Dictionary<string, Metadata>> GetMetadata(List<int> ids)
        {
            return await OnGetMetadata(ids, new List<string>());
        }

        public async Task<Dictionary<string, Metadata>> GetMetadata(List<string> symbols)
        {
            return await OnGetMetadata(new List<int>(), symbols);
        }

        private async Task<Dictionary<string, Metadata>> OnGetMetadata(List<int> ids, List<string> symbols)
        {
            var endpoint = "/v1/cryptocurrency/info";
            var properties = new Dictionary<string, object>();
            if(ids.Count > 0)
            {
                properties.Add("id", String.Join(",",ids.ToArray()));
            }
            if (symbols.Count > 0)
            {
                properties.Add("symbol", String.Join(",", symbols.ToArray()));
            }
            var queryString = DictionaryToString(properties);

            var url = baseUrl + endpoint;
            if (!string.IsNullOrEmpty(queryString))
                url += $"?{queryString}";

            var response = await rest.GetApiStream<ResponseWrapper<Dictionary<string, Metadata>>>(url, GetHeaders());

            return response.Data;
        }

        public async Task<IEnumerable<Map>> GetIDMap(ListingStatus listingStatus)
        {
            return await OnGetIDMap(listingStatus, 0, 0, new List<string>());
        }

        public async Task<IEnumerable<Map>> GetIDMap(ListingStatus listingStatus, int start = 1, int limit = 5000)
        {
            limit = limit > 5000 ? 5000 : limit;

            return await OnGetIDMap(listingStatus, start, limit, new List<string>());
        }

        public async Task<IEnumerable<Map>> GetIDMap(List<string> symbols)
        {
            return await OnGetIDMap(ListingStatus.Both, 0, 0, symbols);
        }

        private async Task<IEnumerable<Map>> OnGetIDMap(ListingStatus listingStatus, int start, int limit, List<string> symbols)
        {
            var endpoint = "/v1/cryptocurrency/map";
            var properties = new Dictionary<string, object>();
            if (listingStatus != ListingStatus.Both)
            {
                properties.Add("listing_status", listingStatus.ToString().ToLower());
            }
            if (start > 0)
            {
                properties.Add("start", start);
            }
            if (limit > 0)
            {
                properties.Add("limit", limit);
            }
            if (symbols.Count > 0)
            {
                properties.Add("symbol", String.Join(",", symbols.ToArray()));
            }
            var queryString = DictionaryToString(properties);

            var url = baseUrl + endpoint;

            if (!string.IsNullOrEmpty(queryString))
                url += $"?{queryString}";

            var response = await rest.GetApiStream<ResponseWrapper<IEnumerable<Map>>>(url, GetHeaders());

            return response.Data;
        }

        private Dictionary<string, string> GetHeaders()
        {
            var headers = new Dictionary<string, string>();

            headers.Add("X-CMC_PRO_API_KEY", apiKey);

            return headers;
        }

        private string DictionaryToString(Dictionary<string, object> dictionary)
        {
            var stringed = string.Join("&", dictionary.Select(d => d.Key + "=" + d.Value));

            return stringed;
        }
    }
}