
namespace Patterns.Behavioral.Strategy.Travel.Transports
{
    using Patterns.Behavioral.Strategy.Travel.Transports.Interface;
    using System;

    public class Bus : IVehicle
    {
        public int Fuel { get; set; }

        public string Move()
        {
            return "Bus is moving";
        }
    }
}
