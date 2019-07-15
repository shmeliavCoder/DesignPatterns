using System;
namespace Design_Patterns_Console.Day2.ChainOfResponsibility.Logs
{
    public class ErrorLogger : LogBase
    {
        public override void Log(string message, int level)
        {
            if(level >= 2)
            {
                Console.WriteLine($"Error: {message}");
            }
            if (next != null)
            {
                next.Log(message, level);
            }
        }
    }
}
