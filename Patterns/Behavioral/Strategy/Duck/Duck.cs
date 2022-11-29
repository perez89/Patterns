namespace Patterns.Behavioral.Strategy.Duck
{
    public class Duck
    {
        protected readonly IFlyBehaviour flyBehaviour;

        public Duck(IFlyBehaviour flyBehaviour) {
            this.flyBehaviour = flyBehaviour;
        }

        public void PerformFly() {
            flyBehaviour.Fly();
        }

        public IFlyBehaviour GetFlyType()
        {
            return flyBehaviour;
        }
    }
}
