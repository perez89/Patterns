namespace Tests.Behavioral.Strategy.Travel;


public class RequestTests
{
    [Fact]
    public void Should_Be_Chrome_Fetch()
    {
        //Arrange
        WebApplication webApplication = new WebApplication(BrowserType.Chrome);

        //Act
        var response = webApplication.SendAsyncRequestToServer("Https://www.google.com");   

        //Assert
        Assert.NotNull(response.Response);
        Assert.Equal("Sent async network request using FETCH XmlHttpRequestApi", response.Response);
    }

    [Fact]
    public void Should_Not_Be_Chrome_Fetch()
    {
        //Arrange
        WebApplication webApplication = new WebApplication(BrowserType.Chrome);

        //Act
        var response = webApplication.SendAsyncRequestToServer("Https://www.google.com");

        //Assert
        Assert.NotNull(response.Response);
        Assert.NotEqual("Sents ad async network request using FETCH XmlHttpRequestApi", response.Response);
    }

    [Fact]
    public void Should_Be_Internet_Xml()
    {
        //Arrange
        WebApplication webApplication = new WebApplication(BrowserType.InternetExplorer);

        //Act
        var response = webApplication.SendAsyncRequestToServer("Https://www.google.com");

        //Assert
        Assert.NotNull(response.Response);
        Assert.Equal("Sent async network request using XHR XmlHttpRequestApi", response.Response);
    }
}


