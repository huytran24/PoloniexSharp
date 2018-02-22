namespace PoloniexSharp.Infrastructure
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PoloniexSharp.Entities;
    using System;
    using System.Linq;

    internal class OrderBookJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(OrderBookResponse);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var asks = jObject["asks"]
                        .Select(t => new Tuple<string, double>((string)t[0], (double)t[1])).ToList();
            var bids = jObject["bids"]
            .Select(t => new Tuple<string, double>((string)t[0], (double)t[1])).ToList();

            return new OrderBookResponse()
            {
                Asks = asks,
                Bids = bids,
                IsFroken = (string)jObject["isFrozen"],
                Seq = (int)jObject["seq"]
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
