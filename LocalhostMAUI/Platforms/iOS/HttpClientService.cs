namespace LocalhostMAUI
{
    public partial class HttpClientService
    {
        public partial HttpMessageHandler GetPlatfromSpecificHttpMessageHandler()
        {
            var handler = new NSUrlSessionHandler
            {
                TrustOverrideForUrl = bool (NSUrlSessionHandlerSender, url, secTrust) => url.StartsWith("https://localhost")
            };
            return handler;
        }
    }
}
