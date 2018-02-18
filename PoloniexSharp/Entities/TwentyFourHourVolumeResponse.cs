namespace PoloniexSharp.Entities
{
    using Newtonsoft.Json;
    using PoloniexSharp.Infrastructure;
    using System.Collections.Generic;

    [JsonConverter(typeof(TwentyFourHourVolumeJsonConverter))]
    public class TwentyFourHourVolumeResponse
    {
        public List<TwentyFourHourVolumeDetails> VolumeCollection { get; set; }
        public double TotalBTC { get; set; }
        public double TotalETH { get; set; }
        public double TotalUSDT { get; set; }
        public double TotalXMR { get; set; }
        public double TotalXUSD { get; set; }

    }
}
