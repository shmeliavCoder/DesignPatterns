using System;

namespace Design_Patterns_Console.Test.Question1
{
    class NewShip : ISpaceShipState
    {
        SpaceShipContext ctx;

        public NewShip(SpaceShipContext context)
        {
            Console.WriteLine($"Welcome to stage: {ctx.currentStage} You have {ctx.HitPoints} hit points left");
            this.ctx = context;
        }

        public ISpaceShipState GetHit(int damage)
        {
            ctx.HitPoints -= damage;

            if (ctx.HitPoints <= 0)
            {
                return new LostGameState(ctx);
            }
            if (ctx.HitPoints <= 10)
            {
                return new DangerGameState(ctx);
            }

            Console.WriteLine($"You are doing fine, You have {ctx.HitPoints} hit points left");
            return this;
        }

        public ISpaceShipState NextStage()
        {
            if(ctx.currentStage == 3)
            {
                return new WonGameState(ctx);
            }
            else
            {
                ctx.currentStage++;
                Console.WriteLine($"Welcome to stage: {ctx.currentStage} Your doing well, you have {ctx.HitPoints} hit points");
                return this;
            }
        }
    }
}