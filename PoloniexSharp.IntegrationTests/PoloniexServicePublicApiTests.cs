namespace PoloniexSharp.IntegrationTests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PoloniexSharp.Services;
    using System.Net;

    // integration tests
    [TestClass]
    public class PoloniexServicePublicApiTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        [TestMethod]
        public void GetTickerReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetTicker();
            response.Should().NotBeNull();
        }

        [TestMethod]
        public void GetCurrenciesReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetCurrencies();
            response.Should().NotBeNull();
        }

        [TestMethod]
        public void Get24HourVolumeReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.Get24HourVolume();
            response.Should().NotBeNull();
        }

        [TestMethod]
        public void GetChartDataReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetChartData("BTC_ETH", 1514764800, 1514851200, Entities.ChartDataPeriodEnum.TwoHours);
            response.Should().NotBeNull();
        }

        [TestMethod]
        public void GetTradeHistoryReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetTradeHistory("BTC_ETH", 1514764800, 1514851200);
            response.Should().NotBeNull();
        }

        [TestMethod]
        public void GetLoanOrdersReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetLoanOrders("BTC");
            response.Should().NotBeNull();
        }

        [TestMethod]
        public void GetOrderBookReturnsResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetOrderBook("BTC_ETH", 10);
            response.Should().NotBeNull();
        }
    }
}
