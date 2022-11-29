
namespace Patterns.Behavioral.Strategy.Travel.Driver
{
    using Patterns.Behavioral.Strategy.Travel.Transports.Interface;

    public interface IJob
    {
        void ChangeTransport(IVehicle vehicle);
        string Go();

    }
}
