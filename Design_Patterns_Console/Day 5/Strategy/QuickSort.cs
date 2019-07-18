using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Console.Day5.Strategy
{
    public class QuickSort : ISort
    {
        public QuickSort()
        {
        }

        public void Sort(IList<int> list)
        {
            Console.WriteLine("Quick sorting");
            
        }
    }
}
