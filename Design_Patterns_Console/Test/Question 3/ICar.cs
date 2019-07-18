using System;
namespace Design_Patterns_Console.Test.Question3
{
    public interface ICar : IGasAndLocation
    {
        void startRide();
        void endRide();
        void incSpeed();
        void decSpeed();

    }
}
