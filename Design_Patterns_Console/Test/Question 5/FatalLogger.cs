using System;
namespace Design_Patterns_Console.Test.Question5
{
    public class FatalLogger : LogBase
    {
        public override void Log(string message, int level)
        {
            if (level >= 1)
            {
                Console.WriteLine($"Send FATAL: {message} to director");
            }
            if (next != null)
            {
                next.Log(message, level);
            }
        }
    }
}
