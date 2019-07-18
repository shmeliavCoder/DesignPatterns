using System;

namespace Design_Patterns_Console.Test.Question5
{
    public class InfoLogger : LogBase
    {
        public override void Log(string message, int level)
        {
            if (level >= 3)
            {
                Console.WriteLine($"Writing info to screen: {message}");
            }
            if (next != null)
            {
                next.Log(message, level);
            }
        }
    }
}
