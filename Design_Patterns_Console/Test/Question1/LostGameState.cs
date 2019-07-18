using System;

namespace Design_Patterns_Console.Test.Question1
{
    internal class LostGameState : ISpaceShipState
    {
        private SpaceShipContext ctx;

        public LostGameState(SpaceShipContext ctx)
        {
            Console.WriteLine($"Game is lost!");
            this.ctx = ctx;
        }

        public ISpaceShipState GetHit(int damage)
        {
            Console.WriteLine($"You already lost the game!");

            return this;
        }

        public ISpaceShipState NextStage()
        {
            Console.WriteLine($"You already lost the game!");

            return this;
        }
    }
}