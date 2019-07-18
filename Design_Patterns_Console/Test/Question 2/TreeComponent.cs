using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Console.Test.Question2
{
    public abstract class TreeComponent
    {
        public int number { get; set; }

        protected TreeComponent(int number)
        {
            this.number = number;
        }

        public abstract void AddChild(TreeComponent c);

        public abstract void RemoveChild(TreeComponent c);

        public abstract IList<TreeComponent> GetChilds();

        public abstract int GetSum();
    }
}
