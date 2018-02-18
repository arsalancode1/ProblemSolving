using ProblemSolving.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();
            //tree.CalculateHeight();
            tree.PrintSpiral();
            Console.ReadLine();
        }
    }
}
