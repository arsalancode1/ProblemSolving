using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    partial class BinaryTree
    {
        public void DistanceBetweenNodes(int n1, int n2)
        {
            Node lca = HasLCA(root, n1, n2);
            int d1 = CalculateDistance(lca, n1);
            int d2 = CalculateDistance(lca, n2);
            Console.WriteLine("Distance is -->" + (d1 + d2).ToString());
            Console.ReadLine();
        }

        // To calculate distance between two nodes in same sub-tree
        private int CalculateDistance(Node node, int n)
        {
            if (node == null)
            {
                return -1;
            }

            if (node.Data == n)
            {
                return 0;
            }

            int d1 = CalculateDistance(node.LeftNode, n);
            int d2 = CalculateDistance(node.RightNode, n);

            if (d1 > -1)
            {
                return ++d1;
            }

            else if (d2 > -1)
            {
                return ++d2;
            }
            else
            {
                return 0;
            }
        }
    }
}
