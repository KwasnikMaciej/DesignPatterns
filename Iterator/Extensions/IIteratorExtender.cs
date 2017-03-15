using System;

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
