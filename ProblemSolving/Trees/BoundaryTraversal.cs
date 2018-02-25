using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    partial class BinaryTree
    {
        public void PrintBoundaryNodes()
        {
            PrintLeftNodes(root);
            PrintLeafNodes(root);
            PrintRightNodes(root.RightNode);
        }

        private void PrintLeftNodes(Node root)
        {
            if (root.LeftNode == null && root.RightNode == null)
            {
                return;
            }

            Console.WriteLine(root.Data);

            if (root.LeftNode != null)
            {
                PrintLeftNodes(root.LeftNode);
            }
            else if (root.RightNode != null)
            {
                PrintLeftNodes(root.RightNode);
            }
        }

        private void PrintLeafNodes(Node root)
        {
            if (root == null)
            {
                return;
            }

            PrintLeafNodes(root.LeftNode);
            PrintLeafNodes(root.RightNode);

            if (root.LeftNode == null && root.RightNode == null)
            {
                Console.WriteLine(root.Data);
            }
        }

        private void PrintRightNodes(Node root)
        {
            if (root.LeftNode == null && root.RightNode == null)
            {
                return;
            }

            if (root.RightNode != null)
            {
                PrintRightNodes(root.RightNode);
                Console.WriteLine(root.Data);
            }
            else if (root.LeftNode != null)
            {
                PrintRightNodes(root.LeftNode);
                Console.WriteLine(root.Data);
            }
        }
    }
}
