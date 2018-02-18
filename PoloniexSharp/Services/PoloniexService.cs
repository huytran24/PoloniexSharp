namespace PoloniexSharp.Services
{
    using Newtonsoft.Json;
    using PoloniexSharp.Entities;
    using PoloniexSharp.Infrastructure;

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
    }
}
