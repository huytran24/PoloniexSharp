namespace PoloniexSharp.Services
{
    using PoloniexSharp.Entities;
    using System.Collections.Generic;

    public interface IPoloniexService
    {
        TwentyFourHourVolumeResponse Get24HourVolume();
        List<ChartData> GetChartData(string currencyPair, int startEpoch, int endEpoch, ChartDataPeriodEnum period);
        CurrencyResponse GetCurrencies();
        LoanOrderResponse GetLoanOrders(string currency);
        OrderBookResponse GetOrderBook(string currencyPair, int depth);
        TickerResponse GetTicker();
        List<TradeHistory> GetTradeHistory(string currencyPair, int startEpoch, int endEpoch);
    }
}