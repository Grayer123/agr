public class Solution {
    public int CountComponents(int n, int[,] edges) {
        // dfs + undirected graph
        // tc:O(n*m); sc:O(n*m)
        if(n == 0 || edges.GetLength(0) == 0) {
            return n;
        }
        Dictionary<int, List<int>> graph = ConstructGraph(n, edges);
        HashSet<int> visited = new HashSet<int>();
        int res = 0;
        for(int i = 0; i < n; i++) {
            if(!visited.Contains(i)) { // has not been visited 
                res++;
                visited.Add(i);
                Dfs(graph, visited, i);
            }
        }
        return res;
        
    }
    private Dictionary<int, List<int>> ConstructGraph(int n, int[,] edges) {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for(int i = 0; i < n; i++) {
            graph[i] = new List<int>(); // create nodes
        }
        for(int i = 0; i < edges.GetLength(0); i++) {  // create edges
            int node1 = edges[i, 0], node2 = edges[i, 1];
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }
        return graph;
    }
    
    private void Dfs(Dictionary<int, List<int>> graph, HashSet<int> visited, int node) {
        foreach(int ngb in graph[node]) {
            if(!visited.Contains(ngb)) {
                visited.Add(ngb);
                Dfs(graph, visited, ngb);
            }
        }
    }
}