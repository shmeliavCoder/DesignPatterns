using System;
namespace Design_Patterns_Console.FactoryMethod
{
    public class Vehicle
    {
        protected string model;

        protected float cylinder;

        protected string color;

        protected int numberOfWheels;

        public Vehicle(string model, float cylinder, string color, int numberOfWheels)
        {
            this.model = model;
            this.cylinder = cylinder;
            this.color = color;
            this.numberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return String.Format("model: {0} \ncylinder: {1} \ncolor: {2} \nnumberOfWheels: {3}",  this.model , this.cylinder, this.color, this.numberOfWheels);
        }
    }
}
