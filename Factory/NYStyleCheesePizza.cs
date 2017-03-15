namespace FactoryMethod
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Cheese Pizza";
            Dough = "Thin Crust";
            Sauce = "Marinara Pizza Sauce";
            
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}