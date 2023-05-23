using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search.Depth_First_Search__DFS_
{
    internal class DepthFirstSearchAlgo
    {
        public void DepthFirstSearch(Dictionary<int, List<int>> graph, int start, HashSet<int> visited)
        {
            if (visited.Contains(start))
            {
                return;
            }

            visited.Add(start);
            Console.WriteLine(start);

            foreach (var neighbour in graph[start])
            {
                DepthFirstSearch(graph, neighbour, visited);
            }
        }
    }
}
