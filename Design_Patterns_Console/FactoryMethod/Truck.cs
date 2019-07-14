using System;
namespace Design_Patterns_Console.FactoryMethod
{
    public class Truck : Vehicle
    {
        protected string truckData;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string truckData) : base(model, cylinder, color, numberOfWheels)
        {
            this.truckData = truckData;
        }

        public override string ToString()
        {
            return String.Format("{0} \ntruckData: {1}", base.ToString(), this.truckData);
        }
    }
}
