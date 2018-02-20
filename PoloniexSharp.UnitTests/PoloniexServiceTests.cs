namespace PoloniexSharp.UnitTests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PoloniexSharp.Services;

    [TestClass]
    public class PoloniexServiceTests
    {
        [TestMethod]
        public void GetTickerReturnsValidResponseTest()
        {
            var service = new PoloniexService();
            var response = service.GetTicker();
            response.Should().NotBeNull();
        }
    }
}
