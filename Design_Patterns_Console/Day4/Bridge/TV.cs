using System;
namespace Design_Patterns_Console.Day4.Bridge
{
    public class TV : EntertainmentDevice
    {
        public TV(int max, bool isOn)
        {
            this.state = 1;
            this.max = max;
            this.isOn = isOn;
        }

        public override void PressNext()
        {
            this.state++;
            this.state = this.state % max;
            Console.WriteLine($"Changed to {state} channel");
        }

        public override void PressPrevious()
        {
            this.state--;
            if (this.state == 0)
            {
                this.state = max;
            }
            Console.WriteLine($"Changed to {state} channel");
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"Current state is: {isOn} and the channel is: {state}");
        }
    }
}
