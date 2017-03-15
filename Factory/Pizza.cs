using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public string Dough { get; set; }

        public string Sauce { get; set; }

        public List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Placing in official PizzaStore box");
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n---- " + Name + " ----\n");
            sb.Append("Dough: " + Dough);
            sb.Append("\nSauce: " + Sauce);
            sb.Append("\nToppings: " + String.Join(", ", Toppings.ToArray()));
            sb.Append("\n----------------------\n");

            return sb.ToString();
        }
    }
}
