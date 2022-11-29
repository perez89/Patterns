

namespace Tests.Behavioral.Strategy.Travel;

public class TravelTests
{
    [Fact]
    public void IsTheTransportACar()
    {
        //Arrange
        var vehicle = new Airplane();
        var vehicle_car = new Car();
        var driver = new CarDriver();
        //Act
        driver.ChangeTransport(vehicle);

        driver.ChangeTransport(vehicle_car);
        var result = driver.Go();

        //Assert
        Assert.NotNull(result);
        Assert.Equal("Car is moving", result);
    }

}


