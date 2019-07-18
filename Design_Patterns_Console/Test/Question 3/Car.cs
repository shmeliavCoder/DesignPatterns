using System;
namespace Design_Patterns_Console.Test.Question3
{
    public class Car : ICar
    {
        int speed;
        bool isRiding;
        int gas;
        string location;

        public Car(string location)
        {
            speed = 0;
            isRiding = false;
            gas = 100;
            this.location = location;
        }

        public void decSpeed()
        {
            if(isRiding && speed > 0)
            {
                Console.WriteLine("Decreasing Speed");
                speed--;
            }
            else
            {
                Console.WriteLine("You are not moving yet.");
            }
        }

        public void endRide()
        {
            isRiding = false;
        }

        public void incSpeed()
        {
            if(isRiding)
            {
                speed++;
                Console.WriteLine($"Increasing Speed to {speed}");
            }
            else
            {
                Console.WriteLine("You are not riding yet.");
            }
        }

        public void showGas()
        {
            Console.WriteLine($"Gas is {gas}");
        }

        public void showLocation()
        {
            Console.WriteLine($"Location is {location}");
        }

        public void startRide()
        {
            isRiding = true;
            speed = 1;
            Console.WriteLine("Ride starting");
        }
    }
}
