using System;
namespace Design_Patterns_Console.ContextState
{
    public class LoginSuccess : LoginBase
    { 
        public LoginSuccess(LoginContext ctx) : base(ctx)
        {
            Console.WriteLine("Login Success");
        }

        public override void Login(string password)
        {
            Console.WriteLine("Already Logged in");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting.. new login");
            ctx.State = new NewLogin(ctx);
        }
    }
}
