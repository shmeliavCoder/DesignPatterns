using System;
namespace Design_Patterns_Console.Test.Question2
{
    public static class StaticFunction
    {
        public static void CheckEven()
        {
            TreeComponent root = new TreeComposite(4);
            TreeComponent level11 = new TreeLeaf(4);
            TreeComponent level12 = new TreeLeaf(4);
            root.AddChild(level11);
            root.AddChild(level12);

            TreeComponent level13 = new TreeComposite(4);
            TreeComponent level21 = new TreeLeaf(4);
            TreeComponent level22 = new TreeLeaf(4);
            level13.AddChild(level21);
            level13.AddChild(level22);

            root.AddChild(level13);

            TreeComponent level14 = new TreeComposite(4);
            TreeComponent level23 = new TreeLeaf(4);
            TreeComponent level24 = new TreeLeaf(4);
            level14.AddChild(level23);
            level14.AddChild(level24);

            root.AddChild(level14);
            Console.WriteLine($"is the tree even? {isEven(root)}");


            root.AddChild(new TreeLeaf(3));
            Console.WriteLine($"is the tree even? {isEven(root)}");
        }

        public static bool isEven(TreeComponent currNode)
        {
            if(currNode.GetChilds() == null && currNode.number % 2 == 0)
            {
                return true;
            }

            if (currNode.number % 2 == 0)
            {
                bool currEven = true;

                foreach (TreeComponent c in currNode.GetChilds())
                {
                    currEven = currEven && isEven(c);
                }

                return currEven;
            }

            return false;
        }
    }
}
