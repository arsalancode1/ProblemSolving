using ProblemSolving.Graphs;
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
            DirectedGraph directedGraph = new DirectedGraph(4);
            directedGraph.AddEdge(0, 1);
            directedGraph.AddEdge(0, 2);
            directedGraph.AddEdge(1, 2);
            directedGraph.AddEdge(2, 0);
            directedGraph.AddEdge(2, 3);
            directedGraph.AddEdge(3, 3);
            directedGraph.DetectCycle();
        }
    }
}
