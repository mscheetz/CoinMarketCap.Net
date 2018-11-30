using CoinMarketCap.Net.DataAccess;
using CoinMarketCap.Net.DataAccess.Interfaces;
using System;
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
        public void GetMetadataSymbol_Test()
        {
            var symbol = "BTC";

            var data = repo.GetMetadata(symbol).Result;

            Assert.NotNull(data);
        }
    }
}
