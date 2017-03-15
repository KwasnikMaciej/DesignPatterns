namespace Decorator
{
    public class Milk : CondimentDecorator
    {
        public Beverage Beverage { get; }

        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override decimal GetCost()
        {
            return Beverage.GetCost() + 0.1M;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Milk";
        }
    }
}
