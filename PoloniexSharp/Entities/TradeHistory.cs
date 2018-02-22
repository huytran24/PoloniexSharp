namespace PoloniexSharp.Entities
{
    using System;
    public class TradeHistory
    {
        public double Amount { get; set; }
        public DateTimeOffset Date { get; set; }
        public int GlobalTradeID { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
        public int TradeID { get; set; }
        public TradeTypeEnum Type { get; set; }
    }
}
