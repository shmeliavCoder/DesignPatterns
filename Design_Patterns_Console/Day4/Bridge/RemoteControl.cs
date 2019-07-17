using System;
namespace Design_Patterns_Console.Day4.Bridge
{
    public class RemoteControl
    {
        public EntertainmentDevice device { get; set; }


        public RemoteControl(EntertainmentDevice device)
        {
            this.device = device;
        }

        public void On()
        {
            this.device.TurnOn();
        }

        public void Off()
        {
            this.device.TurnOff();
        }

        public void next()
        {
            this.device.PressNext();
        }

        public void previous()
        {
            this.device.PressPrevious();
        }
    }
}
