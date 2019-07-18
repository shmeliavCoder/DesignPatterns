using System;
namespace Design_Patterns_Console.Test.Question8
{
    public class Jogging : GymExcerciseBase
    {
        public Jogging()
        {
        }

        protected override void PerformExcercise()
        {
            Console.WriteLine("JOGGING!");
        }
    }
}
