using System;
namespace Design_Patterns_Console.Test.Question10
{
    public class DecoratorLight : DecoratorWindowBase
    {
        public DecoratorLight(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and light";
        }
    }
}
