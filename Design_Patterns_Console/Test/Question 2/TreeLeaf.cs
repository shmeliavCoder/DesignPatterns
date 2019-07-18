using System;
using System.Collections.Generic;

namespace Design_Patterns_Console.Test.Question2
{
    public class TreeLeaf : TreeComponent
    {
        public TreeLeaf(int number) : base(number)
        {
        }

        public override void AddChild(TreeComponent c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<TreeComponent> GetChilds()
        {
            return null;
        }

        public override int GetSum()
        {
            return this.number;
        }

        public override void RemoveChild(TreeComponent c)
        {
            throw new NotSupportedException("Leaf elemnt cannot remove child!");
        }
    }
}