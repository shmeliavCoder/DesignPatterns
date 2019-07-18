using System;
namespace Design_Patterns_Console.Test.Question1
{
    public interface ISpaceShipState
    {
        ISpaceShipState GetHit(int damage);
        ISpaceShipState NextStage();
    }
}
