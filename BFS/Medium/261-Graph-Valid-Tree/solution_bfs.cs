public class Solution {
    public bool ValidTree(int n, int[,] edges) {
        // bfs
        // tc:O(vertex * edge); sc:O(n)
        if(n == 1 && edges.GetLength(0) == 0) { // corner case
            return true;
        }
        Dictionary<int, HashSet<int>> graph = ConstructGraph(n, edges); // need to remove node, so use hashset not list
        HashSet<int> visited = new HashSet<int>(); // need to search whether a node has been visited, so use hashset not list
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0); // undirect graph, add any point as an initial one
        visited.Add(0);
        while(queue.Count > 0) {
            int node = queue.Dequeue();
            foreach(var ngb in graph[node]) {
                if(visited.Contains(ngb)) {
                    return false;
                }
                queue.Enqueue(ngb);
                visited.Add(ngb);
                graph[ngb].Remove(node); // undirectional graph => added twice for each edge
            }
        }
        return visited.Count == n;
    }
    
    private Dictionary<int, HashSet<int>> ConstructGraph(int n, int[,] edges) {
        Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
        for(int i = 0; i < n; i++) {
            graph[i] = new HashSet<int>();
        }
        for(int i = 0; i < edges.GetLength(0); i++) {
            int node1 = edges[i, 0], node2 = edges[i, 1];
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }
        return graph;
    }
}