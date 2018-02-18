namespace PoloniexSharp.Infrastructure
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PoloniexSharp.Entities;
    using System;
    using System.Collections.Generic;

    public class TickerJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TickerResponse);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            var tickerCollection = new List<TickerDetails>();
            foreach (var x in jo)
            {
                string name = x.Key;
                JToken value = x.Value;
                var tickerDetails = JsonConvert.DeserializeObject<TickerDetails>(value.ToString());
                tickerDetails.CurrencyPair = name;
                tickerCollection.Add(tickerDetails);
            }
            return new TickerResponse() { TickerDetails = tickerCollection};
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
