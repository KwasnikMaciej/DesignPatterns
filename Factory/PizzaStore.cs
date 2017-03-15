namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
