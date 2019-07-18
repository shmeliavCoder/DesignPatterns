using System;
namespace Design_Patterns_Console.Test.Question10
{
    public class DecoratorFrame : DecoratorWindowBase
    {
        public DecoratorFrame(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and frame";
        }
    }
}
