namespace PoloniexSharp.Infrastructure
{
    internal static class Urls
    {
        internal static string PublicBaseUrl => "https://poloniex.com/public";

        public static string Ticker => PublicBaseUrl + "?command=returnTicker";
    }
}
