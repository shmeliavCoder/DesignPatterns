using System;
namespace Design_Patterns_Console.Test.Question3
{
    public class CarProxy : IGasAndLocation
    {
        Car car;

        public CarProxy(string location)
        {
            car = new Car(location);
        }

        public void showGas()
        {
            this.car.showGas();
        }

        public void showLocation()
        {
            this.car.showLocation();
        }
    }
}
