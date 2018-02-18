namespace PoloniexSharp.Entities
{
    using Newtonsoft.Json;
    using PoloniexSharp.Infrastructure;
    using System.Collections.Generic;

    [JsonConverter(typeof(TickerJsonConverter))]
    public class TickerResponse
    {
        public List<TickerDetails> TickerDetails { get; set; }
    }
}
