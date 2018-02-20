namespace PoloniexSharp.Entities
{
    using Newtonsoft.Json;
    using PoloniexSharp.Infrastructure;
    using System;
    using System.Collections.Generic;

    [JsonConverter(typeof(OrderBookJsonConverter))]
    public class OrderBookResponse
    {
        public List<Tuple<string, double>> Asks { get; set; }
        public List<Tuple<string, double>> Bids { get; set; }
        public string IsFroken { get; set; }
        public int Seq { get; set; }
    }
}
