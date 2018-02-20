namespace PoloniexSharp.Entities
{
    using Newtonsoft.Json;
    using PoloniexSharp.Infrastructure;
    using System.Collections.Generic;

    [JsonConverter(typeof(CurrenciesJsonConverter))]
    public class CurrencyResponse
    {
        public List<CurrencyDetails> CurrencyDetails { get; set; }
    }
}
