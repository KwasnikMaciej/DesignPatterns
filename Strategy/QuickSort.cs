using System;
using System.Collections.Generic;

namespace Strategy
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("-- Sorting using QuickSort --");
            list.Sort();
        }
    }
}
