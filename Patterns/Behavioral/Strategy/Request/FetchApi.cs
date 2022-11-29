namespace Patterns.Behavioral.Strategy.Request;

internal class FecthApi : IAsyncRequestStrategy
{
    public AsyncResponse SendRequest(string url)
    {
        AsyncResponse asyncResponse = new AsyncResponse();
        asyncResponse.Response = "Sent async network request using FETCH XmlHttpRequestApi";
        Console.WriteLine(asyncResponse.Response);
        return asyncResponse;
    }
}
