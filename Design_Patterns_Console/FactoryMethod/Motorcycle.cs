using System;
namespace Design_Patterns_Console.FactoryMethod
{
    public class Motorcycle : Vehicle
    {
        protected string motorcycleData;

        public Motorcycle(string model, float cylinder, string color, int numberOfWheels, string motorcycleData) : base(model, cylinder, color, numberOfWheels)
        {
            this.motorcycleData = motorcycleData;
        }

        public override string ToString()
        {
            return String.Format("{0} \nmotorcycleData: {1}", base.ToString(), this.motorcycleData);
        }
    }
}
