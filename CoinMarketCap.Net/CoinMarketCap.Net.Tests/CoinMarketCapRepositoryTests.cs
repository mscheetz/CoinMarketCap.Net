using CoinMarketCap.Net.Contracts;
using CoinMarketCap.Net.DataAccess;
using CoinMarketCap.Net.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace CoinMarketCap.Net.Tests
{
    public class CoinMarketCapRepositoryTests : IDisposable
    {
        private readonly ICoinMarketCapRepository repo;

        public CoinMarketCapRepositoryTests()
        {
            var key = "4d2e49c8-65e0-4f61-ab21-1975ad798d49";
            repo = new CoinMarketCapRepository(key, true);
        }

        public void Dispose()
        {
        }

        [Fact]
        public void GetMetadataId_Test()
        {
            var id = 1;

            var data = repo.GetMetadata(id).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetMetadataSymbol_Test()
        {
            var symbol = "BTC";

            var data = repo.GetMetadata(symbol).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetMetadataIds_Test()
        {
            var ids = new List<int> { 1, 2 };

            var data = repo.GetMetadata(ids).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetMetadataSymbols_Test()
        {
            var symbol = "BTC,ETH";

            var data = repo.GetMetadata(symbol).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetMetadataSymbolList_Test()
        {
            var symbols = new List<string> { "BTC", "ETH" };

            var data = repo.GetMetadata(symbols).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetIDMap_Test()
        {
            var data = repo.GetIDMap().Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetIDMapNumbers_Test()
        {
            var data = repo.GetIDMap(50, 20).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetIDMapListingStatus_Test()
        {
            var status = ListingStatus.Active;

            var data = repo.GetIDMap(status).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetIDMapSymbols_Test()
        {
            var symbols = new List<string> { "BTC,ETH,XLM" };

            var data = repo.GetIDMap(symbols).Result;

            Assert.NotNull(data);
        }

        [Fact]
        public void GetIDMapComplex_Test()
        {
            var status = ListingStatus.Active;

            var data = repo.GetIDMap(status, 50, 20).Result;

            Assert.NotNull(data);
        }
    }
}
