

namespace Tests.Behavioral.Strategy.Travel;


public class DuckTests
{
    [Fact]
    public void IsTheDuck()
    {
        //Arrange
        var _fly = new FlyWithWings();
        var duck = new UglyDuck(_fly);

        //Act
        duck.PerformFly();
        var flyType = duck.GetFlyType();


        //Assert
        Assert.IsType<FlyWithWings>(flyType);
        Assert.IsNotType<NoFlyWithWings>(flyType);

    }

}


