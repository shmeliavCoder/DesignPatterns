using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Console.Test.ToughtQuestion2
{
    public static class WordListCounter
    {
        public static void countWords(string[] list)
        {
            Dictionary<string, int> bucket = new Dictionary<string, int>();

            foreach(string str in list)
            {
                string key = String.Concat(str.OrderBy(c => c));
                int times;
                if(bucket.TryGetValue(key, out times))
                {
                    bucket.Remove(key);
                    bucket.Add(key, times + 1);
                }
                else
                {
                    bucket.Add(key, 1);
                }
            }

            foreach(string key in bucket.Keys)
            {
                int temp;
                bucket.TryGetValue(key, out temp);
                Console.WriteLine($"number of {key} is {temp}");
            }
        }

        public static void testCountWords()
        {
            string[] lst = {"java", "jjava" ,"vaj", "aavj", "j", "vjaa", "dan", "and", "ddan"};

            countWords(lst);
        }
    }
}
