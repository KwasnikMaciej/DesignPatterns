using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var NYStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var cheesePizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine(cheesePizza.ToString());
            var veggiePizza = NYStore.OrderPizza("veggie");
            Console.WriteLine(veggiePizza.ToString());

            Console.ReadKey();
        }
    }
}
