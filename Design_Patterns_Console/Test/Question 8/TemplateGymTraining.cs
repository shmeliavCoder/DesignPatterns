using System;
namespace Design_Patterns_Console.Test.Question8
{
    public abstract class TemplateGymTraining
    {
        protected abstract void SwitchToGymClothes();
        protected abstract void DrinkWater();
        protected abstract void PerformExcercise();
        protected abstract void Shower();

        public void Excercise()
        {
            SwitchToGymClothes();
            DrinkWater();
            PerformExcercise();
            Shower();
        }
    }
}
