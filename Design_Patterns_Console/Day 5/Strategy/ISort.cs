using System;
using System.Collections.Generic;

namespace Design_Patterns_Console.Day5.Strategy
{
    public interface ISort
    {
        void Sort(IList<int> list);
    }
}
