using System;

namespace Strategy
{
    public class MainClass
    {
        static void Main()
        {
            SortedList students = new SortedList();

            students.Add("Janek");
            students.Add("Andzej");
            students.Add("Zygmunt");
            students.Add("Krzysiek");
            students.Add("Anna");

            students.SetSortStrategy(new QuickSort());
            students.Sort();
            students.Print();

            students.SetSortStrategy(new InsertionSort());
            students.Sort();

            students.SetSortStrategy(new MergeSort());
            students.Sort();

            Console.ReadKey();
        }
    }
}
