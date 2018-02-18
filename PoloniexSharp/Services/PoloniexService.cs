namespace PoloniexSharp.Services
{
    using Newtonsoft.Json;
    using PoloniexSharp.Entities;
    using PoloniexSharp.Infrastructure;
    using System.Collections.Generic;

    public class PoloniexService
    {
        public virtual TickerResponse GetTicker()
        {
            var result = JsonConvert.DeserializeObject<TickerResponse>(Requestor.GetString($"{Urls.Ticker}"));
            return result;
        }
    }
}
