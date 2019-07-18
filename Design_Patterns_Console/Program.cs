using System;
using ChainOfResp;
using Design_Patterns_Console.Class1;
using Design_Patterns_Console.ContextState;
using Design_Patterns_Console.Day2.ChainOfResponsibility.Logs;
using Design_Patterns_Console.FactoryMethod;
using State;
using CompositeX;
using ProtoType;
using Visitor;
using Design_Patterns_Console.Day3.Adapter.DBData;
using Design_Patterns_Console.Day4.Decorator;
using Design_Patterns_Console.Day4.Decorator.Calculator;
using Design_Patterns_Console.Day4.Bridge;
using System.Collections.Generic;
using Design_Patterns_Console.Day5.Strategy;
using Design_Patterns_Console.Test.Question2;
using Design_Patterns_Console.Test.ToughtQuestion2;

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
            //ChainOfRepoQuestion();

            // Question six:
            //CompositeQuestion();

            // Question Seven
            //PrototypeQuestion();

            // DAY THREE:

            // Question eight
            //VisitorQuestion();

            // Question Nine
            //AdapterQuestion();

            // Question ten
            //DecoratorCalcQuestion();

            // Question Eleven
            // StrategyQuestion();

            // TEST:
            ///StaticFunction.CheckEven();
            ///
            WordListCounter.testCountWords();
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


        public static bool isBinary(Component current)
        {
            if (current.GetChilds() == null || current.GetChilds().Count == 0)
            {
                return true;
            }
            if (current.GetChilds().Count == 2)
            {
                return isBinary(current.GetChilds()[0]) && isBinary(current.GetChilds()[1]);
            }

            return false;
        }

        public static void CompositeQuestion()
        {
            Component root = new Composite("Canvas root");
            Component circle1 = new Leaf("Circle 1");
            Component rectangle = new Leaf("Rectangle x");
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite("Container 1");
            Component circle2 = new Leaf("Circle 1");
            Component circle3 = new Leaf("Circle 2");
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite("Container of triangles");
            Component t1 = new Leaf("Triangle 1");
            Component t2 = new Leaf("Triangle 2");
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            root.Draw("");
            Console.WriteLine($"ROOT COUNT: {root.CountLeaf()}");
            Console.WriteLine($"isBinary {isBinary(root)}");
        }

        public static void PrototypeQuestion()
        {

            Circle c = new Circle(new Point(5, 5), 50.5);

            Square sq = new Square(new Point(1, 1), new Point(4, 4));

            Square sq2 = new Square(new Point(1, 5), new Point(4, 9));

            ShapeContainer shapeContainer = new ShapeContainer();

            shapeContainer.addItem(c);
            shapeContainer.addItem(sq);
            shapeContainer.addItem(sq2);

            ShapeContainer shapeContainer2 = shapeContainer.clone();

            sq.BR = new Point(3, 3);


            Console.WriteLine(shapeContainer);
            Console.WriteLine(shapeContainer2);
        }

        public static void PrototypeWeb()
        {

        }

        public static void VisitorQuestion()
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            ShopRent shop = new ShopRent();

            Console.WriteLine(shop);

            IVisitor oneShekelStore = new OneShekelStore();

            Console.WriteLine($"Price at oneshekelstore = {shop.Accept(oneShekelStore)}");

            Console.WriteLine($"Price after tax = {shop.Accept(endOfYearVisitor)}");
        }

        public static void AdapterQuestion()
        {
            WebClientData webcd = new WebClientData("name", 1, "1.0.1.0", true);

            draw(new BadStoreToPerfectStoreAdapter(), webcd);

            Console.WriteLine("\n====================");
            Console.WriteLine("Print before the adapter");
            Console.WriteLine("\n====================\n");

            draw(new BadStore(), webcd);
        }

        // non mutable
        private static void draw(IDBWebData dbwebdata, WebClientData webcd)
        {
            dbwebdata.Store(webcd);
        }

        public static void DecoratorCalcQuestion()
        {
            IFormula formula = new StartNumber(5);
            formula = new MethodMulDecorator(formula, 2);
            formula = new MethodAddDecorator(formula, 100);
            formula = new MethodDivDecorator(formula, 12);
            formula = new MethodSubDecorator(formula, 3);
            formula = new MethodMulDecorator(formula, 4);
            formula = new MethodAddDecorator(formula, 7);

            Console.WriteLine($"{formula.GetFormula()} Result: {formula.GetResult()}");

        }

        public static void BridgeQuestion()
        {
            TV xd = new TV(99, true);
            Memir mem = new Memir(70, true);
            RemoteControl rmctl = new RemoteControl(xd);
            rmctl.next();
            rmctl.next();
            rmctl.next();
            rmctl.next();
            rmctl.next();
            rmctl.Off();
            
            rmctl = new RemoteControl(mem);
            rmctl.next();
            rmctl.next();
            rmctl.next();
            rmctl.next();
            rmctl.next();
            rmctl.Off();
        }

        public static void StrategyQuestion()
        {
            NumberCollection lst = new NumberCollection();
            for (int i = 0; i < 1000; i++)
            {
                lst.Add(i);
            }

            lst.Sort();
            lst.remove(50);
            lst.Sort();
            lst.Add(50);
            lst.Sort();
        }
    }
}