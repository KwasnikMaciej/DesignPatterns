using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            arrayMenuIterator.PrintMenu();
            arrayListMenuIterator.PrintMenu();

            Console.ReadKey();
        }
    }
}
