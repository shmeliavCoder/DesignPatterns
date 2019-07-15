using System;
namespace Design_Patterns_Console.Day2.ChainOfResponsibility.Logs
{
    public class FatalLogger : LogBase
    {
        public override void Log(string message, int level)
        {
            if (level >= 1)
            {
                Console.WriteLine($"FATAL: {message}");
            }
            if (next != null)
            {
                next.Log(message, level);
            }
        }
    }
}
