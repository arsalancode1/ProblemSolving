using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Trees
{
    partial class BinaryTree
    {
        public void FindLCA()
        {
            Console.WriteLine(HasLCA(root, 5, 3).Data);
            Console.ReadLine();
        }

        private Node HasLCA(Node node,int n1,int n2)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data == n1 || node.Data == n2)
            {
                return node;
            }

            Node t1 = HasLCA(node.LeftNode, n1, n2);
            Node t2 = HasLCA(node.RightNode, n1, n2);

            if (t1 != null && t2 != null)
            {
                return node;
            }

            return t1 != null ? t1 : t2;
        }
    }
}
