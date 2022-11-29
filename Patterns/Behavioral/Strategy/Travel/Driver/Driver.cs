
namespace Patterns.Behavioral.Strategy.Travel.Driver
{
    using Patterns.Behavioral.Strategy.Travel.Transports.Interface;
    using System;

   public class Driver : IJob
    {
        public IVehicle Transport { get; set; }
    }
}
