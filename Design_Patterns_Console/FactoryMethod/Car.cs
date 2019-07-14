using System;
namespace Design_Patterns_Console.FactoryMethod
{
    public class Car : Vehicle
    {
        protected string carData;

        public Car(string model, float cylinder, string color, int numberOfWheels, string carData) : base(model, cylinder, color, numberOfWheels)
        {
            this.carData = carData;
        }

        public override string ToString()
        {
            return String.Format("{0} \ncarData: {1}", base.ToString(), this.carData);
        }
    }
}
