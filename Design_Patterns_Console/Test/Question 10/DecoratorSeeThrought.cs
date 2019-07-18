using System;
namespace Design_Patterns_Console.Test.Question10
{
    public class DecoratorSeeThrought : DecoratorWindowBase
    {
        public DecoratorSeeThrought(IWindow window) : base(window)
        {
        }

        public override string PrintWindow()
        {
            return this.Window.PrintWindow() + " and look through";
        }
    }
}
