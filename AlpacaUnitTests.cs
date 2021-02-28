using StockTrading.Libraries;
using StockTrading.Test.APIKeys;
using System;
using Xunit;

namespace StockTrading.Test
{
    public class AlpacaUnitTests
    {
        private AlpacaMarketData _marketData = new AlpacaMarketData(AlpacaAPIKeys.ApiKey,AlpacaAPIKeys.SecretKey);
        [Fact]
        public async void CheckAlpacaMarketResponse()
        {
            var response = await _marketData.MarketTimesGet();

            Assert.IsType<bool>(response.Item1);
            Assert.IsType<DateTime>(response.Item2);
        }
    }
}
