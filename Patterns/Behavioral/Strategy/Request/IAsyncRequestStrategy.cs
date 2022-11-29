namespace Patterns.Behavioral.Strategy.Request;

public interface IAsyncRequestStrategy
{
    AsyncResponse SendRequest(string url);
}
