namespace Decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.SetDescription("Espresso");
        }

        public override decimal GetCost()
        {
            return 1.99M;
        }
    }
}
