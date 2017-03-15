using System.Collections.Generic;

namespace FactoryMethod
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Veggie Pizza";
            Dough = "Crust";
            Sauce = "Marinara Pizza Sauce";

            Toppings.Add("Shredded Mozzarella");
            Toppings.Add("Grated Parmesan");
            Toppings.Add("Diced Onion");
            Toppings.Add("Sliced Mushrooms");
            Toppings.Add("Sliced Black Olives");
        }
    }
}