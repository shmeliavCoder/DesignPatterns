﻿using System;
using ChainOfResp;
using Design_Patterns_Console.Class1;
using Design_Patterns_Console.ContextState;
using Design_Patterns_Console.Day2.ChainOfResponsibility.Logs;
using Design_Patterns_Console.FactoryMethod;
using State;

namespace Design_Patterns_Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // DAY ONE:

            // Question one:
            //SingletonQuestion();

            // Question two:
            //FactoryQuestion();

            // Question three:
            //StateQuestion();

            // Question four
            //StateContextQuestion();

            // DAY TWO:

            // Question five:
            ChainOfRepoQuestion();
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

        public static void StateContextQuestion()
        {
            LoginContext ctx = new LoginContext();
            NewLogin nl = new NewLogin(ctx);
            ctx.Init(nl);

            ctx.Login("123");
            ctx.Login("123");
            ctx.Login("123");
            ctx.Login("123");
            ctx.Login("123");
            ctx.Login("123");
            ctx.Restart();
            ctx.Login("123");
            ctx.Login("12345");
        }

        public static void ChainOfRepoQuestion()
        {
            BillHandlerBase billHandler500 = new BillHandler500();
            BillHandlerBase billHandler200 = new BillHandler200();
            BillHandlerBase billHandler100 = new BillHandle100();
            BillHandlerBase billHandler25 = new BillHandle25();
            BillHandlerBase coinHandler5 = new CoinHandler5();
            BillHandlerBase coinHandler2 = new CoinHandler2();

            BillHandlerBase chainRoot = billHandler500;
            billHandler500.SetNext(billHandler200);
            billHandler200.SetNext(billHandler100);
            billHandler100.SetNext(billHandler25);
            billHandler25.SetNext(coinHandler5);
            coinHandler5.SetNext(coinHandler2);

            Console.WriteLine("748:");
            chainRoot.Handle(748);
            Console.WriteLine("==================");
            Console.WriteLine("385:");
            chainRoot.Handle(385);
            Console.WriteLine("==================");
            Console.WriteLine("400:");
            chainRoot.Handle(400);
            Console.WriteLine("==================");
            Console.WriteLine("402:");
            chainRoot.Handle(402);

            Console.WriteLine("LogsPart ============");

            LogBase fatalLogger = new FatalLogger();
            LogBase errorLogger = new ErrorLogger();
            LogBase debugLogger = new DebugLogger();
            LogBase infoLogger = new InfoLogger();

            LogBase chainRootLog = fatalLogger;
            fatalLogger.SetNext(errorLogger);
            errorLogger.SetNext(debugLogger);
            debugLogger.SetNext(infoLogger);

            chainRootLog.Log("Dude", 1);
            Console.WriteLine("==================");
            chainRootLog.Log("Memoization", 4);
            Console.WriteLine("==================");
            chainRootLog.Log("XD TV", 3);

            LogBase chainRootLog2 = infoLogger;
            infoLogger.SetNext(debugLogger);
            debugLogger.SetNext(errorLogger);
            errorLogger.SetNext(fatalLogger);
            fatalLogger.SetNext(null);

            chainRootLog2.Log("Dude", 1);
            Console.WriteLine("==================");
            chainRootLog2.Log("Memoization", 4);
            Console.WriteLine("==================");
            chainRootLog2.Log("XD TV", 3);
        }
    }
}