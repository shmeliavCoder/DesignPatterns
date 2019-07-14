using System;
namespace Design_Patterns_Console.ContextState
{
    public class LoginContext
    {
        public ILoginState State { get; set; }

        public LoginContext()
        {
        }

        public void Init(ILoginState state)
        {
            this.State = state;
        }

        public void Login(string passwd)
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");

            State.Login(passwd);
        }

        public void Restart()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");

            State.Restart();
        }
    }    
}
