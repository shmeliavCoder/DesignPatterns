using System;
namespace Design_Patterns_Console.ContextState
{
    public class Locked : LoginBase
    {
        public Locked(LoginContext ctx) : base(ctx)
        {
        }

        public override void Login(string password)
        {
            Console.WriteLine("You are locked. restart and try again");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting.. new login");
            ctx.State = new NewLogin(ctx);
        }
    }
}
