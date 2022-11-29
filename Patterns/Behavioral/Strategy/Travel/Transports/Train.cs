
namespace Patterns.Behavioral.Strategy.Travel.Transports
{
    using Patterns.Behavioral.Strategy.Travel.Transports.Interface;
    using System;

    public class Train : IVehicle
    {
        public int Fuel { get; set; }

        public string Move()
        {
            return "Train is moving";
        }
    }
}
