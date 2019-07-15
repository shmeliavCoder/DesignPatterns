using System;
namespace Design_Patterns_Console.FactoryMethod
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {
        }


        public Vehicle GetVehicle(string model, float cylinder, string color, int numberOfWheels, string data)
        {
            if(numberOfWheels == 1)
            {
                return new Saguie(model, cylinder, color, numberOfWheels, data);
            }
            else if(numberOfWheels == 2)
            {
                return new Motorcycle(model, cylinder, color, numberOfWheels, data);
            }
            else if(numberOfWheels == 4)
            {
                return new Car(model, cylinder, color, numberOfWheels, data);
            }
            else if(numberOfWheels == 8)
            {
                return new Truck(model, cylinder, color, numberOfWheels, data);
            }

            throw (new Exception("Invalid number of wheels"));
        }
    }
}
