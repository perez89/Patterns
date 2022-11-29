namespace Patterns.Behavioral.Strategy.Request;

internal class XmlHttpRequestApi : IAsyncRequestStrategy
{
    public AsyncResponse SendRequest(string url)
    {
        AsyncResponse asyncResponse = new AsyncResponse();
        asyncResponse.Response = "Sent async network request using XHR XmlHttpRequestApi";
        Console.WriteLine(asyncResponse.Response);
        return asyncResponse;
    }
}
