using System;
namespace Design_Patterns_Console.Test.Question8
{
    public abstract class GymExcerciseBase : TemplateGymTraining
    {
        protected override void SwitchToGymClothes()
        {
            Console.WriteLine("Switch to gym clothes");
        }

        protected override void DrinkWater()
        {
            Console.WriteLine("Drinking water..");
        }

        protected override void Shower()
        {
            Console.WriteLine("Showering after workout");
        }
    }
}
