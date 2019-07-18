using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question12
{
    public abstract class PCBuilder
    {
        protected PC computer;

        public PC GetComputer()
        {
            if (computer == null)
                this.BuildComputer();

            return computer;
        }

        public void BuildComputer()
        {
            this.computer = new PC();
            BuildPackage();
            AddMotherBoard();
            AddProcessor();
            AddGraphicsCard();
            AddMemory();
        }

        protected abstract void BuildPackage();
        protected abstract void AddMemory();
        protected abstract void AddMotherBoard();
        protected abstract void AddProcessor();
        protected abstract void AddGraphicsCard();
    }
}
