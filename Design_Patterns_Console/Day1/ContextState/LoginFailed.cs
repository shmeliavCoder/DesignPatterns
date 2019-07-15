using System;
namespace Design_Patterns_Console.ContextState
{
    public class LoginFailed : LoginBase
    {
        int count;

        public LoginFailed(LoginContext ctx) : base(ctx)
        {
            this.count = 2;
        }

        public override void Login(string password)
        {
            if (password == "12345")
            {
                ctx.State = new LoginSuccess(ctx);
            }
            else
            {
                this.count--;
                if(count == 0)
                {
                    Console.WriteLine("Failed 3 times.. you are locked");
                    ctx.State = new Locked(ctx);
                } else
                {
                    Console.WriteLine("Failed 2 times.. one more try");
                }
            }
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting.. new login");
            ctx.State = new NewLogin(ctx);
        }
    }
}
