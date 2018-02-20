using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }

    partial class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = new Node(10);
            root.LeftNode = new Node(8);
            root.RightNode = new Node(2);
            root.LeftNode.LeftNode = new Node(3);
            root.LeftNode.RightNode = new Node(5);
            root.RightNode.LeftNode = new Node(1);
        }

        public void DetectSumpath(int sum)
        {
            Console.WriteLine("Tree has Sum Path {0} --> {1}", sum.ToString(), HasSumPath(sum, root));
            Console.ReadLine();
        }

        private bool HasSumPath(int sum, Node node)
        {
            if (node == null)
            {
                return (sum == 0);
            }
            else
            {
                bool result = false; ;

                int subSum = sum - node.Data;
                if (node.LeftNode != null && node.RightNode != null)
                {

                    result = (HasSumPath(subSum, node.LeftNode) || HasSumPath(subSum, node.RightNode));
                }

                if (node.LeftNode == null && node.RightNode == null)
                {
                    result = (subSum == 0);
                }

                if (node.LeftNode == null && node.RightNode != null)
                {
                    result = (false || HasSumPath(subSum, node.RightNode));
                }

                if (node.LeftNode != null && node.RightNode == null)
                {
                    result = (false || HasSumPath(subSum, node.LeftNode));
                }

                return result;
            }
        }
    }
}