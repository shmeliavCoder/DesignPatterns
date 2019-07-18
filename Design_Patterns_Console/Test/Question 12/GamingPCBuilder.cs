using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question12
{
    public class GamingComputerBuilder : PCBuilder
    {
        protected override void BuildPackage()
        {
            computer.BuildPackage("Building regular package");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("Adding regular mother board");
        }

        protected override void AddProcessor()
        {
            computer.AddProcessor("Adding strong Processor");
        }

        protected override void AddGraphicsCard()
        {
            computer.AddProcessor("Adding strong graphics card");
        }

        protected override void AddMemory()
        {
            computer.AddMemory("Adding lots of memory");
        }
    }
}