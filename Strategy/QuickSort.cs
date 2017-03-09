using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
