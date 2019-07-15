using System;
namespace Design_Patterns_Console.ContextState
{
    public abstract class LoginBase : ILoginState
    {
        protected LoginContext ctx;

        protected LoginBase(LoginContext ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);

        public abstract void Restart();
    }   
}
