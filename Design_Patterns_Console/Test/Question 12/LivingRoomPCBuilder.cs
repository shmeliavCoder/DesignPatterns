using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question12
{
    public class LivingRoomComputerBuilder : PCBuilder
    {
        protected override void BuildPackage()
        {
            computer.BuildPackage("Building living room package");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("Adding extra thin motherboard");
        }

        protected override void AddProcessor()
        {
            computer.AddProcessor("Adding regular Processor");
        }

        protected override void AddGraphicsCard()
        {
            computer.AddProcessor("Adding strong graphic card");
        }

        protected override void AddMemory()
        {
            computer.AddMemory("Adding regular memmory");
        }
    }
}
