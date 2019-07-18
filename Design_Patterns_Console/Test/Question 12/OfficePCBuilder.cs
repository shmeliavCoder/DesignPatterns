using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question12
{
    public class OfficePCBuilder : PCBuilder
    {
        protected override void BuildPackage()
        {
            computer.BuildPackage("Building package");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("Adding mother board");
        }

        protected override void AddProcessor()
        {
            computer.AddProcessor("Adding Processor");
        }

        protected override void AddGraphicsCard()
        {
            computer.AddProcessor("Adding graphic card");
        }

        protected override void AddMemory()
        {
            computer.AddMemory("Adding memmory");
        }
    }
}
