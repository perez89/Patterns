

namespace Patterns.Behavioral.Strategy.Duck
{
    public class UglyDuck : Duck
    {
        public UglyDuck(IFlyBehaviour fly):base(fly)
        {
           
        }
        public new void PerformFly() {
            flyBehaviour.Fly();
        }

     
    }
}
