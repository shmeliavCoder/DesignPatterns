using System;
namespace Design_Patterns_Console.ContextState
{
    public interface ILoginState
    {
        void Login(string password);

        void Restart();
    }
}
