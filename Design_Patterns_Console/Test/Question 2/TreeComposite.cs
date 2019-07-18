using System;
using System.Collections.Generic;

namespace Design_Patterns_Console.Test.Question2
{
    public class TreeComposite : TreeComponent
    {
        IList<TreeComponent> childs = new List<TreeComponent>();

        public TreeComposite(int number) : base(number)
        {
           
        }

        public override void AddChild(TreeComponent c)
        {
            childs.Add(c);
        }

        public override IList<TreeComponent> GetChilds()
        {
            return childs;
        }

        public override int GetSum()
        {
            int sum = this.number;

            foreach (TreeComponent c in childs)
            {
                sum += c.GetSum();
            }

            return sum;
        }

        public override void RemoveChild(TreeComponent c)
        {
            childs.Remove(c);
        }
    }
}
