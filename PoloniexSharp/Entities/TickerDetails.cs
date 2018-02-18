namespace PoloniexSharp.Entities
{
    public class TickerDetails
    {
        public int Id { get; set; }
        public string CurrencyPair { get; set; }
        public double Last { get; set; }
        public double LowestAsk { get; set; }
        public double HighestBid { get; set; }
        public double PercentChange { get; set; }
        public double BaseVolume { get; set; }
        public double QuoteVolume { get; set; }
        public string IsFrozen { get; set; }
        public double High24hr { get; set; }
        public double Low24hr { get; set; }
    }
}
