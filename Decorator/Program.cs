using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var espresso = new Espresso();
            Console.WriteLine(espresso.GetDescription() + " - $" + espresso.GetCost());

            var espressoWithMilk = new Milk(new Espresso());
            Console.WriteLine(espressoWithMilk.GetDescription() + " - $" + espressoWithMilk.GetCost());

            Console.ReadKey();
        }
    }
}
