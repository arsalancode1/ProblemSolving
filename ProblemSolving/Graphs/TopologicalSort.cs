using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Graphs
{
    partial class DirectedGraph
    {
        public void TopologicalSort()
        {
            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++)
            {
                visited[i] = false;
            }

            Stack<int> sortedNodes = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                SortUtil(i, visited, sortedNodes);
            }

            foreach(int j in sortedNodes)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }

        public void SortUtil(int node, bool[] visited,Stack<int> stack)
        {
            if (!visited[node])
            {
                visited[node] = true;
                if (graph.ContainsKey(node))
                {
                    foreach (int key in graph[node])
                    {
                        SortUtil(key, visited, stack);
                    }
                }

                stack.Push(node);
            }
        }
    }
}
