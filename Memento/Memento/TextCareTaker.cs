using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        int current = -1;
        List<TextMemento> mementos = new List<TextMemento>();

        public void AddMemento(TextMemento memento)
        {
            this.mementos.Add(memento);
            this.current = this.mementos.Count - 1;
        }

        public TextMemento GetLast()
        {
            this.current = this.getNextIndex();

            if (current != -1)
                return this.mementos[current];

            return null;
        }

        public TextMemento GetPrevious()
        {
            this.current = this.getPreviousIndex();

            if (current != -1)
                return this.mementos[current];

            return null;
        }

        private int getNextIndex()
        {
            if(this.mementos.Count == 0)
                return -1;
            
            if(current == 0)
                return this.mementos.Count - 1;
            return this.current - 1;
        }

        private int getPreviousIndex()
        {
            if (this.mementos.Count == 0)
                return -1;

            if (current == this.mementos.Count - 1)
                return 0;
            return this.current + 1;
        }
    }
}
