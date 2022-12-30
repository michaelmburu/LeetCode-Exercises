using System;
namespace LeetCode50Exercises
{
    public class CloneGraph
    {
        /*
         * Clone an undirected graph
         * Bread-first search O(n)
        */
        private UndirectedGraphNode cloneGraph(UndirectedGraphNode graph)
        {
            if (graph == null) return null;
            Dictionary<UndirectedGraphNode, UndirectedGraphNode> map = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            return DFS(graph, map);
        }

        private UndirectedGraphNode DFS(UndirectedGraphNode graph, Dictionary<UndirectedGraphNode, UndirectedGraphNode> map)
        {
            if (map.ContainsKey(graph))
            {
                return map.GetValueOrDefault(graph);
            }
        }


    }
}

