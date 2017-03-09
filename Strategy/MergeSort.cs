using System;
using System.Collections.Generic;

namespace Strategy
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("-- Sorting using MergeSort --");
            //list.MergeSort();
        }
    }
}
