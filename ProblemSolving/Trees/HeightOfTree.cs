using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    partial class BinaryTree
    {
        private int CalculateHeight(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(CalculateHeight(node.LeftNode), CalculateHeight(node.RightNode));
        }

        public void CalculateHeight()
        {
            Console.WriteLine(CalculateHeight(root));
            Console.ReadLine();
        }
    }
}
