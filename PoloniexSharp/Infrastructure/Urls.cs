namespace PoloniexSharp.Infrastructure
{
    using PoloniexSharp.Entities;

    internal static class Urls
    {
        internal static string PublicBaseUrl => "https://poloniex.com/public";
        public static string Ticker => PublicBaseUrl + "?command=returnTicker";
        public static string TwentyFourHourVolume => PublicBaseUrl + "?command=return24hVolume";

        public static string OrderBook(string currencyPair, int depth)
        {
            if (depth > 0)
            {
                return PublicBaseUrl + $"?command=returnOrderBook&currencyPair={currencyPair}&depth={depth}";
            }
            return PublicBaseUrl + $"?command=returnOrderBook&currencyPair={currencyPair}";
        }

        public static string TradeHistory(string currencyPair, int startEpoch, int endEpoch)
        {
            return PublicBaseUrl + $"?command=returnTradeHistory&currencyPair={currencyPair}&start={startEpoch}&end={endEpoch}";
        }

        public static string ChartData(string currencyPair, int startEpoch, int endEpoch, ChartDataPeriodEnum period)
        {
            return PublicBaseUrl + $"?command=returnChartData&currencyPair={currencyPair}&start={startEpoch}&end={endEpoch}&period={(int)period}";
        }

        public static string Currencies => PublicBaseUrl + "?command=returnCurrencies";
        public static string LoanOrders(string currency)
        {
            return PublicBaseUrl + $"?command=returnLoanOrders&currency={currency}";
        }
    }
}