using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph.Dijkstra_s_Algorithm
{
    internal class DijkstraAlgo
    {
        public static int[] Dijkstra(Dictionary<int, List<Tuple<int, int>>> graph, int source, int vertices)
        {
            int[] distance = new int[vertices];
            bool[] shortestPathTreeSet = new bool[vertices];

            for (int i = 0; i < vertices; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < vertices - 1; ++count)
            {
                int u = MinDistance(distance, shortestPathTreeSet, vertices);

                shortestPathTreeSet[u] = true;

                foreach (var i in graph[u])
                {
                    if (!shortestPathTreeSet[i.Item1] && distance[u] != int.MaxValue && distance[u] + i.Item2 < distance[i.Item1])
                    {
                        distance[i.Item1] = distance[u] + i.Item2;
                    }
                }
            }

            return distance;
        }

        static int MinDistance(int[] dist, bool[] sptSet, int vertices)
        {
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < vertices; ++v)
            {
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }

            return min_index;
        }


    }
}
