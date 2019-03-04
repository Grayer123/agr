public class Solution {
    public bool ValidTree(int n, int[,] edges) {
        // dfs
        // tc:O(vertex * edge); sc:O(n)
        if(n == 1 && edges.GetLength(0) == 0) { // corner case
            return true;
        }
        Dictionary<int, HashSet<int>> graph = ConstructGraph(n, edges); // need to remove node, so use hashset not list
        HashSet<int> visited = new HashSet<int>(); // need to search whether a node has been visited, so use hashset not list
        visited.Add(0);
        bool res = Dfs(graph, visited, 0); // undirect graph, add any point as an initial one
        return visited.Count == n ? res : false;
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
    
    private bool Dfs(Dictionary<int, HashSet<int>> graph, HashSet<int> visited, int node) {
        foreach(var ngb in graph[node]) {
            graph[ngb].Remove(node); // undirectional graph => added twice for each edge
            if(visited.Contains(ngb)) {
                return false;
            }
            visited.Add(ngb);
            bool tmpRes = Dfs(graph, visited, ngb); // get the result from sub-dfs
            if(!tmpRes) {
                return false;
            }
        }
        return true;
    }
}