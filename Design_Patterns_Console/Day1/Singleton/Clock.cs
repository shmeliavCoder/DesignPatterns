using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Class1
{
    public class Clock
    {
        private static Clock INSTANCE;
        private static object key = new Object();

        private Clock()
        {

        }

        public static Clock GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }

            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Clock();
                }
            }

            return INSTANCE;
        }

        public void printTimeToConsole()
        {
            Console.WriteLine(DateTime.Now);
        } 
    }
}