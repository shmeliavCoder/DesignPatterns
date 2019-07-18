using System;
using System.Collections.Generic;

namespace Design_Patterns_Console.Day5.Strategy
{
    public class MergeSort : ISort
    {
        public MergeSort()
        {
        }

        public void Sort(IList<int> list)
        {
            Console.WriteLine("Merge sorting");
        }
    }
}
