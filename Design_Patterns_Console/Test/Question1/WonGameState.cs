using System;

namespace Design_Patterns_Console.Test.Question1
{
    internal class WonGameState : ISpaceShipState
    {
        private SpaceShipContext ctx;

        public WonGameState(SpaceShipContext ctx)
        {
            Console.WriteLine("You won the game!");
            this.ctx = ctx;
        }

        public ISpaceShipState GetHit(int damage)
        {
            Console.WriteLine($"You already won the game!");

            return this;
        }

        public ISpaceShipState NextStage()
        {
            Console.WriteLine($"You already won the game!");

            return this;
        }
    }
}