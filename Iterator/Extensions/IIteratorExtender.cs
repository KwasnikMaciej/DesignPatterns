using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public static class IIteratorExtender
    {
        public static void PrintMenu(this IIterator iterator)
        {
            Console.WriteLine("-- PrintMenu method - Start --");
            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext());
            }
            Console.WriteLine("-- PrintMenu method - End --\n");
        }
    }
}
