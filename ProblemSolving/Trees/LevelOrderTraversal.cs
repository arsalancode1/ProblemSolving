using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    partial class BinaryTree
    {
        public void PrintLevelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            if (root != null)
                queue.Enqueue(root);
           
            while (queue.Count > 0)
            {
                Node tempNode = queue.Dequeue();
                Console.WriteLine(tempNode.Data);

                if (tempNode.LeftNode != null)
                    queue.Enqueue(tempNode.LeftNode);
                if (tempNode.RightNode != null)
                    queue.Enqueue(tempNode.RightNode);
            }
        }
    }
}
