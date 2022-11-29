

namespace Patterns.Behavioral.Strategy.Duck
{
    using System;
    public class NoFlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly!!!!");
        }
    }
}
