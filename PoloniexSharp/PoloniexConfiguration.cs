namespace PoloniexSharp
{
    using System;
    using System.Net.Http;

    public static class PoloniexConfiguration
    {
        /// <summary>
        /// This option allows you to provide your own HttpMessageHandler. Useful with Android/iPhone.
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; }

        public static TimeSpan? HttpTimeSpan { get; set; }

        private static string _apiKey;

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(_apiKey))
            {
#if NET45
                _apiKey = System.Configuration.ConfigurationManager.AppSettings["PoloniexApiKey"];
#endif
            }

            return _apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _apiKey = newApiKey;
        }
    }
}
