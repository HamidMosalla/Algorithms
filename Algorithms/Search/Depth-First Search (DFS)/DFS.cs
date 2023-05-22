using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search.Depth_First_Search__DFS_
{
    internal class DFS
    {
        public void DFSImplementation(Dictionary<int, List<int>> graph, int start, HashSet<int> visited)
        {
            if (visited.Contains(start))
            {
                return;
            }

            visited.Add(start);
            Console.WriteLine(start);

            foreach (var neighbour in graph[start])
            {
                DFSImplementation(graph, neighbour, visited);
            }
        }
    }
}
