using System;
namespace Design_Patterns_Console.ContextState
{
    public class NewLogin : LoginBase
    {
        public NewLogin(LoginContext ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            if(password == "12345")
            {
                ctx.State = new LoginSuccess(ctx);
            } else
            {
                Console.WriteLine("Failed once.. two times left");
                ctx.State = new LoginFailed(ctx);
            }
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting.. new login");
            ctx.State = new NewLogin(ctx);
        }
    }
}
