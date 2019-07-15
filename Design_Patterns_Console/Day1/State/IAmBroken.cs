using System;
namespace State

{
    public class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("I am broken... light will not turn off");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("I am broken... light will not turn on");
            return this;
        }   
    }
}
