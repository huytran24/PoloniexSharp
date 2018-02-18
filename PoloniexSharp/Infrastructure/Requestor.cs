namespace PoloniexSharp.Infrastructure
{
    using System;
    using System.Net.Http;
    using System.Text;

    internal static class Requestor
    {
        internal static HttpClient HttpClient { get; private set; }
        static Requestor()
        {
            HttpClient =
                PoloniexConfiguration.HttpMessageHandler != null
                    ? new HttpClient(PoloniexConfiguration.HttpMessageHandler)
                    : new HttpClient();

            if (PoloniexConfiguration.HttpTimeSpan.HasValue)
                HttpClient.Timeout = PoloniexConfiguration.HttpTimeSpan.Value;
        }

        // Synchronous requests
        public static string GetString(string url)
        {
            var wr = GetRequestMessage(url, HttpMethod.Get);

            return ExecuteRequest(wr);
        }

        public static string PostString(string url)
        {
            var wr = GetRequestMessage(url, HttpMethod.Post);

            return ExecuteRequest(wr);
        }

        private static HttpRequestMessage GetRequestMessage(string url, HttpMethod method)
        {

            var request = BuildRequest(method, url);

            return request;
        }

        private static HttpRequestMessage BuildRequest(HttpMethod method, string url)
        {
            if (method != HttpMethod.Post)
                return new HttpRequestMessage(method, new Uri(url));

            var postData = string.Empty;
            var newUrl = url;

            if (!string.IsNullOrEmpty(new Uri(url).Query))
            {
                postData = new Uri(url).Query.Substring(1);
                newUrl = url.Substring(0, url.IndexOf("?", StringComparison.CurrentCultureIgnoreCase));
            }

            var request = new HttpRequestMessage(method, new Uri(newUrl))
            {
                Content = new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")
            };

            return request;
        }

        private static string ExecuteRequest(HttpRequestMessage requestMessage)
        {
            var response = HttpClient.SendAsync(requestMessage).Result;
            var responseText = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode) return responseText;

            return String.Empty;
        }
    }
}
