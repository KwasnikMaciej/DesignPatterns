using System.Collections.Generic;

namespace FactoryMethod
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "Thin Crust";
            Sauce = "Marinara Pizza Sauce";

            Toppings.Add("Shredded Mozzarella");
            Toppings.Add("Grated Parmesan");
            Toppings.Add("Sliced Black Olives");
        }
    }
}