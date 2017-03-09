using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
