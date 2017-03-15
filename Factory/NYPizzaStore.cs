namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if(type.ToLower() == "cheese")
            {
                return new NYStyleCheesePizza();
            }

            if (type.ToLower() == "veggie")
            {
                return new NYStyleVeggiePizza();
            }

            return null;
        }
    }
}
