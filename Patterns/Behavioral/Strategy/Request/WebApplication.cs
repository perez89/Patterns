namespace Patterns.Behavioral.Strategy.Request;

public class WebApplication
{
    private BrowserType _browserType;

	public WebApplication(BrowserType browserType)
	{
		_browserType = browserType;
	}

	public AsyncResponse SendAsyncRequestToServer(string url) {

		IAsyncRequestStrategy asyncRequestStrategy;
        AsyncResponse asyncResponse = null;

        switch (_browserType){
			case BrowserType.InternetExplorer:
				asyncRequestStrategy = new XmlHttpRequestApi();
                return asyncRequestStrategy.SendRequest(url);
            case BrowserType.Chrome:
				asyncRequestStrategy = new FecthApi();
                return asyncRequestStrategy.SendRequest(url);
        }

        return asyncResponse;
    }
}
