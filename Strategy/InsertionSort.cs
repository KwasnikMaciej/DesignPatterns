using System;
using System.Collections.Generic;

namespace Strategy
{
    public class InsertionSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.InsertionSort();
            Console.WriteLine("-- Sorting using InsertionSort --");
        }
    }
}
