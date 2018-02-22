namespace PoloniexSharp.Services
{
    using Newtonsoft.Json;
    using PoloniexSharp.Entities;
    using PoloniexSharp.Infrastructure;
    using System;
    using System.Collections.Generic;

    public class PoloniexService : IPoloniexService
    {
        public virtual TwentyFourHourVolumeResponse Get24HourVolume()
        {
            var result = JsonConvert.DeserializeObject<TwentyFourHourVolumeResponse>(Requestor.GetString($"{Urls.TwentyFourHourVolume}"));
            return result;
        }

        public virtual List<ChartData> GetChartData(string currencyPair, int startEpoch, int endEpoch, ChartDataPeriodEnum period)
        {
            if (String.IsNullOrWhiteSpace(currencyPair))
            {
                throw new ArgumentException();
            }

            var result = JsonConvert.DeserializeObject<List<ChartData>>(
                            Requestor.GetString(Urls.ChartData(currencyPair, startEpoch, endEpoch, period)));
            return result;
        }

        public virtual CurrencyResponse GetCurrencies()
        {
            var result = JsonConvert.DeserializeObject<CurrencyResponse>(
                            Requestor.GetString(Urls.Currencies));
            return result;
        }

        public virtual LoanOrderResponse GetLoanOrders(string currency)
        {
            if (String.IsNullOrWhiteSpace(currency))
            {
                throw new ArgumentException();
            }

            var result = JsonConvert.DeserializeObject<LoanOrderResponse>(
                            Requestor.GetString(Urls.LoanOrders(currency)));
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

            var result = JsonConvert.DeserializeObject<OrderBookResponse>(
                        Requestor.GetString(Urls.OrderBook(currencyPair, depth)));
            return result;
        }

        public virtual TickerResponse GetTicker()
        {
            var result = JsonConvert.DeserializeObject<TickerResponse>(Requestor.GetString($"{Urls.Ticker}"));
            return result;
        }
        public virtual List<TradeHistory> GetTradeHistory(string currencyPair, int startEpoch, int endEpoch)
        {
            if (String.IsNullOrWhiteSpace(currencyPair))
            {
                throw new ArgumentException();
            }

            var result = JsonConvert.DeserializeObject<List<TradeHistory>>(
                            Requestor.GetString(Urls.TradeHistory(currencyPair, startEpoch, endEpoch)));
            return result;
        }
    }
}
