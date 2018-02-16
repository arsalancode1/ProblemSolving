using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Graphs
{
    partial class WeightedDirectedGraph
    {
        Dictionary<int, List<AdjListNode>> graph;
        int count;

        public WeightedDirectedGraph(int count)
        {
            graph = new Dictionary<int, List<AdjListNode>>();
            this.count = count;
        }

        public void AddEdge(int u, int v, int weight)
        {
            if(!graph.ContainsKey(u))
            {
                graph.Add(u, new List<AdjListNode>());
            }

            graph[u].Add(new AdjListNode() { V = v, Weight = weight });
        }

        public void LongestPath(int source)
        {
            int[] longestPath = new int[count];
            for (int i = 0; i < count; i++)
            {
                longestPath[i] = Int32.MinValue;
            }

            longestPath[source] = 0;

            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++)
            {
                visited[i] = false;
            }

            Stack<int> topologicalSort = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                SortUtil(i, visited, topologicalSort);
            }

            foreach(int u in topologicalSort)
            {
                if (graph.ContainsKey(u))
                {
                    foreach (AdjListNode v in graph[u])
                    {
                        if (longestPath[u] != Int32.MinValue)
                        {
                            if (longestPath[u] + v.Weight > longestPath[v.V])
                            {
                                longestPath[v.V] = longestPath[u] + v.Weight;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Longest path from source vertex {0} to destination vertex {1} is {2}", source, i, longestPath[i] != Int32.MinValue ? longestPath[i].ToString() : "NA");
            }

            Console.ReadLine();
        }

        public void SortUtil(int node, bool[] visited, Stack<int> stack)
        {
            if (!visited[node])
            {
                visited[node] = true;
                if (graph.ContainsKey(node))
                {
                    foreach (AdjListNode key in graph[node])
                    {
                        SortUtil(key.V, visited, stack);
                    }
                }

                stack.Push(node);
            }
        }
    }

    class AdjListNode
    {
        public int V { get; set; }
        public int Weight { get; set; }
    }
}
