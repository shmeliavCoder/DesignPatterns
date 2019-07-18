using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question1
{
    public class SpaceShipContext
    {
        ISpaceShipState state;
        public int HitPoints { get; set; }
        public int currentStage { get; internal set; }

        public SpaceShipContext()
        {
            this.state = new NewShip(this);
            this.HitPoints = 50;
        }

        public void GetHit(int damage)
        {
            this.state = state.GetHit(damage);
        }

        public void NextStage()
        {
            this.state = state.NextStage();
        }
    }
}
