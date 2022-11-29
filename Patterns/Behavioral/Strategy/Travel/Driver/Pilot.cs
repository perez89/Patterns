
namespace Patterns.Behavioral.Strategy.Travel.Driver
{
    using Patterns.Behavioral.Strategy.Travel.Transports.Interface;

    public abstract class Pilot : IJob
    {
        private IVehicle _vehicle { get; set; }

      

        public void ChangeTransport(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string Go() => _vehicle.Move();
    }
}
