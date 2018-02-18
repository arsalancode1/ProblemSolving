using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    partial class BinaryTree
    {
        public void PrintSpiral()
        {
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();

            if (root != null)
                stack1.Push(root);

            while (stack1.Count > 0 || stack2.Count > 0)
            {
                while (stack1.Count > 0)
                {
                    Node tempNode = stack1.Pop();
                    Console.WriteLine(tempNode.Data);
                    if (tempNode.LeftNode != null)
                        stack2.Push(tempNode.LeftNode);
                    if (tempNode.RightNode != null)
                        stack2.Push(tempNode.RightNode);
                }

                while (stack2.Count > 0)
                {
                    Node tempNode = stack2.Pop();
                    Console.WriteLine(tempNode.Data);
                    if (tempNode.RightNode != null)
                        stack1.Push(tempNode.RightNode);
                    if (tempNode.LeftNode != null)
                        stack1.Push(tempNode.LeftNode);
                }
            }
        }
    }
}
