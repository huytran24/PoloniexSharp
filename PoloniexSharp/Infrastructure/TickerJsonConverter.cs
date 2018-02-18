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
            JObject jObject = JObject.Load(reader);
            var tickerCollection = new List<TickerDetails>();
            foreach (var objProp in jObject)
            {
                string currencyPair = objProp.Key;
                JToken ticker = objProp.Value;
                var tickerDetails = JsonConvert.DeserializeObject<TickerDetails>(ticker.ToString());
                tickerDetails.CurrencyPair = currencyPair;
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
