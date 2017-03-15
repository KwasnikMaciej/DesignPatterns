using System;

namespace FactoryMethod
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";

            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting into square slices");
        }
    }
}