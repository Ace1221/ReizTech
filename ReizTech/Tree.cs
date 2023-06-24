using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech
{
    class Tree
    {
        private Branch root;
        public void SetRoot(Branch root)
        {
            this.root = root;
        }
        public Branch GetRoot()
        {
            return root;
        }
        public int GetDepth()
        {
            if (root == null)
                return 0;
            return GetDepthHelper(root);
        }
        private int GetDepthHelper(Branch currentBranch)
        {
            List<Branch> children = currentBranch.GetBranches();
            if (children.Count == 0)
                return 1;
            int maxDepth = -1;
            foreach (Branch child in children)
            {
                int childDepth = 1 + GetDepthHelper(child);
                if (childDepth > maxDepth)
                    maxDepth = childDepth;
            }
            return maxDepth;
        }
        /*        private static void Main(string[] args)
                {

                    char exitChar;
                    do
                    {
                        Tree exampleTree = new Tree();
                        Branch rootBranch = new Branch();
                        Branch left = new Branch();
                        Branch right = new Branch();
                        rootBranch.AddBranch(left);
                        rootBranch.AddBranch(right);
                        Branch leftLeft = new Branch();
                        left.AddBranch(leftLeft);
                        Branch rightLeft = new Branch();
                        Branch rightCenter = new Branch();
                        Branch rightRight = new Branch();
                        right.AddBranch(rightLeft);
                        right.AddBranch(rightCenter);
                        right.AddBranch(rightRight);
                        Branch rightLeftLeft = new Branch();
                        rightLeft.AddBranch(rightLeftLeft);
                        Branch rightCenterLeft = new Branch();
                        Branch rightCenterRight = new Branch();
                        rightCenter.AddBranch(rightCenterLeft);
                        rightCenter.AddBranch(rightCenterRight);
                        Branch rightCenterLeftCenter = new Branch();
                        rightCenterLeft.AddBranch(rightCenterLeftCenter);
                        exampleTree.SetRoot(rootBranch);
                        Console.WriteLine(exampleTree.GetDepth());
                        Console.WriteLine();
                        Console.WriteLine("Press 'x' to exit.");
                        exitChar = Console.ReadKey().KeyChar;
                    }
                    while (exitChar != 'x' && exitChar != 'X');


                }*/

    }
}
