namespace LocalhostMAUI
{
    public partial class HttpClientService
    {
        public HttpClient GetPlatfromSpecificHttpClient()
        {
            var httpMesageHandler = GetPlatfromSpecificHttpMessageHandler();
            return new HttpClient(httpMesageHandler);
        }
        public partial HttpMessageHandler GetPlatfromSpecificHttpMessageHandler();
    }
}
