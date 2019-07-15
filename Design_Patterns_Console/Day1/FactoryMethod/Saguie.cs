using System;
namespace Design_Patterns_Console.FactoryMethod
{
    public class Saguie : Vehicle
    {
        protected string saguieData;

        public Saguie(string model, float cylinder, string color, int numberOfWheels, string saguieData) : base(model, cylinder, color, numberOfWheels)
        {
            this.saguieData = saguieData;
        }

        public override string ToString()
        {
            return String.Format("{0} \nmotorcycleData: {1}", base.ToString(), this.saguieData);
        }
    }
}
