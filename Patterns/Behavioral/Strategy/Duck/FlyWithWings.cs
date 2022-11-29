

namespace Patterns.Behavioral.Strategy.Duck
{
    using System;
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!!!");
        }
    }
}
