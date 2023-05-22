using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search.Binary_Search
{
    public class BreadthFirstSearch
    {
        public void BFS(Dictionary<int, List<int>> graph, int start)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();

            visited.Add(start);
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                Console.WriteLine(node);

                foreach (var neighbour in graph[node])
                {
                    if (!visited.Contains(neighbour))
                    {
                        visited.Add(neighbour);
                        queue.Enqueue(neighbour);
                    }
                }
            }
        }

    }
}
