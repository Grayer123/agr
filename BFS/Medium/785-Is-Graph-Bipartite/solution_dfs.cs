public class Solution {
    public bool IsBipartite(int[][] graph) {
        // dfs
        // tc:O(n); sc:O(n)
        if(graph.GetLength(0) == 0) {
            return true;
        }
        int n = graph.Length;
        int[] color = Enumerable.Repeat(-1, graph.Length).ToArray(); // -1: empty; 0: left; 1: right
        for(int i = 0; i < graph.Length; i++) {
            if(color[i] == -1) {
                color[i] = 0;
                if(!Dfs(graph, color, i)) {
                    return false;
                }
            }
        }
        return true;
    }
    private bool Dfs(int[][] graph, int[] color, int node) {
        foreach(var ngb in graph[node]) {
            if(color[ngb] == -1) { // empty->unvisited
                color[ngb] = color[node] ^ 1; // xor: 0 ^ 1 = 1; 1 ^ 1 = 0
                if(!Dfs(graph, color, ngb)) {
                    return false;
                }
            }
            else if(color[ngb] == color[node]) { // on the same side
                return false;
            }
        }
        return true;
    }
}