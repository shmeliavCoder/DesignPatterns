using System;
using Design_Patterns_Console.Class1;
using Design_Patterns_Console.FactoryMethod;
using State;

namespace Design_Patterns_Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Question one:
            //SingletonQuestion();

            //Question two:
            //FactoryQuestion();

            //Question three:
            StateQuestion();
        }

        public static void SingletonQuestion()
        {
            Clock c1 = Clock.GetInstance();            Clock c2 = Clock.GetInstance();            Clock c3 = Clock.GetInstance();            c1.printTimeToConsole();            c1.printTimeToConsole();            c1.printTimeToConsole();
        }

        public static void FactoryQuestion()
        {
            VehicleFactory vf = new VehicleFactory();

            Vehicle v1 = vf.GetVehicle("ohev", (float)1.2, "red", 4, "data");
            Console.WriteLine(v1 + "\n");

            Vehicle v2 = vf.GetVehicle("truck", (float)1.2, "red", 8, "data");
            Console.WriteLine(v2 + "\n");

            Vehicle v3 = vf.GetVehicle("unicycle", (float)1.2, "yellow", 1, "data");
            Console.WriteLine(v3 + "\n");
        }

        public static void StateQuestion()
        {
            Context ctx = new Context(new IAmOn());
            ctx.pressedOff();
            ctx.pressedOff();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOn();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOff();
        }
    }
}
