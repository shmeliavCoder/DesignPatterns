using System;

namespace Design_Patterns_Console.Class1
{
    public class Singleton
    {
        private static Singleton INSTANCE;
        private static object key = new Object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(INSTANCE != null)
            {
                return INSTANCE;
            }

            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Singleton();
                }
            }

            return INSTANCE;
        }
    }
}
