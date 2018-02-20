using System;
using System.Collections.Generic;

namespace PoloniexSharp.Entities
{
    public class OrderBookResponse
    {
        public List<Tuple<string, double>> Asks { get; set; }
        public List<Tuple<string, double>> Bids { get; set; }

    }
}
