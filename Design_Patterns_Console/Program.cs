using System;
using Design_Patterns_Console.Class1;

namespace Design_Patterns_Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Clock c1 = Clock.GetInstance();            Clock c2 = Clock.GetInstance();            Clock c3 = Clock.GetInstance();            c1.printTimeToConsole();            c1.printTimeToConsole();            c1.printTimeToConsole();
        }
    }
}
