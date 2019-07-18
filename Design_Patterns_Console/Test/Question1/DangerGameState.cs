using System;

namespace Design_Patterns_Console.Test.Question1
{
    internal class DangerGameState : ISpaceShipState
    {
        private SpaceShipContext ctx;

        public DangerGameState(SpaceShipContext ctx)
        {
            Console.WriteLine($"Your in the danger zone you only have {ctx.HitPoints} hit points");
            this.ctx = ctx;
        }

        public ISpaceShipState GetHit(int damage)
        {
            ctx.HitPoints -= damage;

            if (ctx.HitPoints <= 0)
            {
                return new LostGameState(ctx);
            }

            Console.WriteLine($"Your in the danger zone you only have {ctx.HitPoints} hit points");

            return this;
        }

        public ISpaceShipState NextStage()
        {
            if (ctx.currentStage == 3)
            {
                return new WonGameState(ctx);
            }
            else
            {
                ctx.currentStage++;
                Console.WriteLine($"Welcome to stage: {ctx.currentStage} Your in the danger zone you only have {ctx.HitPoints} hit points");
                return this;
            }
        }
    }
}