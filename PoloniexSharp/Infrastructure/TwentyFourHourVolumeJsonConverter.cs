namespace PoloniexSharp.Infrastructure
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PoloniexSharp.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class TwentyFourHourVolumeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TwentyFourHourVolumeResponse);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            var volumeCollection = new List<TwentyFourHourVolumeDetails>();
            string[] propertiesToSkip = { "totalBTC", "totalETH", "totalUSDT", "totalXMR", "totalXUSD" };

            foreach (var objProp in jObject)
            {
                if (propertiesToSkip.Any(objProp.Key.Contains)) continue;
                string currencyPair = objProp.Key;
                var currencyVolumes = JsonConvert.DeserializeObject<Dictionary<string, double>>(objProp.Value.ToString());
                volumeCollection.Add(new TwentyFourHourVolumeDetails
                {
                    CurrencyPair = currencyPair,
                    Volumes = currencyVolumes
                });
            }
            return new TwentyFourHourVolumeResponse()
            {
                VolumeCollection = volumeCollection,
                TotalBTC = jObject["totalBTC"].Value<double>(),
                TotalETH = jObject["totalETH"].Value<double>(),
                TotalXMR = jObject["totalUSDT"].Value<double>(),
                TotalUSDT = jObject["totalXMR"].Value<double>(),
                TotalXUSD = jObject["totalXUSD"].Value<double>()
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
