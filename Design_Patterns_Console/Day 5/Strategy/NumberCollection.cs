using System;
using System.Collections.Generic;


namespace Design_Patterns_Console.Day5.Strategy
{
    public class NumberCollection
    {
        public List<int> lst;
        public ISort srt;

        public NumberCollection()
        {
            lst = new List<int>();
            srt = new MergeSort();
        }

        public void Add(int number)
        {
            if(lst.Count == 999)
            {
                srt = new QuickSort();
            }
            lst.Add(number);
        }

        public void remove(int number)
        {
            if (lst.Count == 1000)
            {
                srt = new MergeSort();
            }
            lst.Remove(number);
        }

        public void Sort()
        {
            this.srt.Sort(lst);
        }
    }
}
