using System;
namespace Design_Patterns_Console.Day2.ChainOfResponsibility.Logs
{
    public class DebugLogger : LogBase
    {
        public override void Log(string message, int level)
        {
            if (level >= 4)
            {
                Console.WriteLine($"Debug: {message}");
            }
            if(next != null)
            {
                next.Log(message, level);
            }
            
        }
    }
}
