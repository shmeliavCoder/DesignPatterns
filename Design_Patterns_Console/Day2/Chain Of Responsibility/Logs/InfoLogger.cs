using System;
namespace Design_Patterns_Console.Day2.ChainOfResponsibility.Logs
{
    public class InfoLogger : LogBase
    {
        public override void Log(string message, int level)
        {
            if (level >= 3)
            {
                Console.WriteLine($"Info: {message}");
            }
            if (next != null)
            {
                next.Log(message, level);
            }
        }
    }
}
