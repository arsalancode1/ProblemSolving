using System;
using System.Collections.Generic;

namespace ProblemSolving.Graphs
{
    partial class DirectedGraph
    {
        Dictionary<int,List<int>> graph;
        int count;
        public DirectedGraph(int count)
        {
            this.count = count;
            graph = new Dictionary<int,List<int>>();
        }

        public void AddEdge(int x, int y)
        {
            if (!graph.ContainsKey(x))
            {
                graph.Add(x, new List<int>());
            }

            graph[x].Add(y);
        }

        public void DetectCycle()
        {

            bool[] visited = new bool[count];
            bool[] recStack = new bool[count];
            for (int i = 0; i < count; i++)
            {
                visited[i] = false;
                recStack[i] = false;
            }

            bool cyclic = false;
            for (int i = 0; i < count; i++)
            {
               cyclic = IsCyclicUtil(i, visited, recStack);
            }

            Console.WriteLine("Graph is cyclic -->>" + cyclic);
            Console.ReadLine();
        }

        private bool IsCyclicUtil(int key, bool[] visited, bool[] recStack)
        {
            if (!visited[key])
            {
                visited[key] = true;
                recStack[key] = true;
                if (graph.ContainsKey(key))
                {
                    foreach (int key1 in graph[key])
                    {
                        if (IsCyclicUtil(key1, visited, recStack))
                        {
                            return true;
                        }
                    }
                }
            }

            else if (visited[key] && recStack[key])
            {
                recStack[key] = false;
                return true;
            }

            recStack[key] = false;
            return false;
        }
    }
}
