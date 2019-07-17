using System;
namespace Design_Patterns_Console.Day4.Bridge
{
    public abstract class EntertainmentDevice
    {
        public int state { get; set; }
        public int max { get; set; }
        public bool isOn { get; set; }

        public EntertainmentDevice()
        {
        }

        public abstract void PrintStatus();
        public abstract void PressNext();
        public abstract void PressPrevious();

        public void TurnOn()
        {
            this.isOn = true;
        }

        public void TurnOff()
        {
            this.isOn = false;
        }
    }
}
