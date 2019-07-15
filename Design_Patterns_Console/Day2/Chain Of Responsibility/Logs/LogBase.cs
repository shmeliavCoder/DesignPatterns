using System;

namespace Design_Patterns_Console.Day2.ChainOfResponsibility.Logs
{
    public abstract class LogBase
    {
        protected LogBase next;

        public abstract void Log(string message, int level);

        public void SetNext(LogBase next)
        {
            this.next = next;
        }
    }
}