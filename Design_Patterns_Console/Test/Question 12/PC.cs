using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question12
{
    public class PC
    {

        private List<String> parts = new List<String>();

        
        public List<String> GetParts()
        {
            return this.parts;
        }

        public void BuildPackage(String package)
        {
            parts.Add(package);
        }

        public void AddMemory(String memory)
        {
            parts.Add(memory);
        }

        public void AddMotherBoard(String motherBoard)
        {
            parts.Add(motherBoard);
        }

        public void AddGraphicsCard(String graphicsCard)
        {
            parts.Add(graphicsCard);
        }

        public void AddProcessor(String processor)
        {
            parts.Add(processor);
        }
    }
}
