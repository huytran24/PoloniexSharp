namespace PoloniexSharp.Infrastructure
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PoloniexSharp.Entities;
    using System;
    using System.Collections.Generic;

    public class CurrenciesJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(CurrencyResponse);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            var currenciesCollection = new List<CurrencyDetails>();
            foreach (var objProp in jObject)
            {
                string symbol = objProp.Key;
                JToken ticker = objProp.Value;
                var currencyDetails = JsonConvert.DeserializeObject<CurrencyDetails>(ticker.ToString());
                currencyDetails.CurrencySymbol = symbol;
                currenciesCollection.Add(currencyDetails);
            }
            return new CurrencyResponse() { CurrencyDetails = currenciesCollection};
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
