using System;

namespace Design_Patterns_Console.Test.Question5
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