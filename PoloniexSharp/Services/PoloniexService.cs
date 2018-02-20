namespace PoloniexSharp.Services
{
    using Newtonsoft.Json;
    using PoloniexSharp.Entities;
    using PoloniexSharp.Infrastructure;
    using System;

    public class PoloniexService
    {
        public virtual TickerResponse GetTicker()
        {
            var result = JsonConvert.DeserializeObject<TickerResponse>(Requestor.GetString($"{Urls.Ticker}"));
            return result;
        }

        public virtual TwentyFourHourVolumeResponse Get24HourVolume()
        {
            var result = JsonConvert.DeserializeObject<TwentyFourHourVolumeResponse>(Requestor.GetString($"{Urls.TwentyFourHourVolume}"));
            return result;
        }

        public virtual OrderBookResponse GetOrderBook(string currencyPair, int depth)
        {
            if (String.IsNullOrWhiteSpace(currencyPair))
            {
                throw new ArgumentException();
            }

            if (depth <= 0)
            {
                throw new ArgumentException();
            }

            var result = JsonConvert.DeserializeObject<OrderBookResponse>(Requestor.GetString(Urls.OrderBook(currencyPair, depth)));
            return result;
        }
    }
}
