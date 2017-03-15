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
            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext());
            }
        }
    }
}
