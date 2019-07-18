using System;
namespace Design_Patterns_Console.Test.Question10
{
    public class DecoratorShadow : DecoratorWindowBase
    {
        public DecoratorShadow(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and shadow";
        }
    }
}