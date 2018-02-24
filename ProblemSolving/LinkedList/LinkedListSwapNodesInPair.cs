using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LinkedList
{
    partial class LinkList
    {
        private LinkListNode head;
        public LinkList()
        {
            head = new LinkListNode(1);
            head.Next = new LinkListNode(2);
            head.Next.Next = new LinkListNode(3);
            head.Next.Next.Next = new LinkListNode(4);
            head.Next.Next.Next.Next = new LinkListNode(5);
        }

        public void PrintSwapedNodes()
        {
            LinkListNode currentNode = head;
            LinkListNode lastNode = null;
            int i = 0;
            while (currentNode != null && currentNode.Next != null)
            {
                LinkListNode nextPairNode = currentNode.Next.Next;
                currentNode.Next.Next = currentNode;
                if (i == 0)
                {
                    head = currentNode.Next;
                    i++;
                }

                if (lastNode != null)
                {
                    lastNode.Next = currentNode.Next;
                }

                lastNode = currentNode;
                currentNode.Next = null;
                currentNode = nextPairNode;
            }

            if (currentNode != null)
            {
                lastNode.Next = currentNode;
            }

            currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }

    class LinkListNode
    {
        public LinkListNode Next { get; set; }

        public LinkListNode(int data)
        {
            this.Data = data;
        }

        public int Data { get; set; }
    }
}
