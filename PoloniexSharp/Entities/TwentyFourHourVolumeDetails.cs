namespace PoloniexSharp.Entities
{
    using System.Collections.Generic;
    public class TwentyFourHourVolumeDetails
    {
        public string CurrencyPair { get; set; }
        public Dictionary<string, double> Volumes { get; set; }
    }
}
