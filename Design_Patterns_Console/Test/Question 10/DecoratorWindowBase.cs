using System;
namespace Design_Patterns_Console.Test.Question10
{
    public abstract class DecoratorWindowBase : IWindow
    {
        public IWindow Window { get; set; }
        public DecoratorWindowBase(IWindow window)
        {
            this.Window = window;
        }

        public abstract string PrintWindow();
    }
}
