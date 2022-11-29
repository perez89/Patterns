
namespace Patterns.Behavioral.Strategy.Travel.Transports
{
    using Patterns.Behavioral.Strategy.Travel.Transports.Interface;
    using System;

    public class Airplane : IVehicle
    {
        public int Fuel { get; set; }

        public string Move()
        {
            return "Airplane is moving";
        }
    }
}
