using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayMenu = new ArrayMenu();
            var arrayListMenu = new ArrayListMenu();

            var arrayMenuIterator = arrayMenu.CreateIterator();
            var arrayListMenuIterator = arrayListMenu.CreateIterator();

            Console.WriteLine("ArrayMenu:");
            arrayMenuIterator.PrintMenu();
            Console.WriteLine("\nArrayListMenu:");
            arrayListMenuIterator.PrintMenu();

            Console.ReadKey();
        }
    }
}
