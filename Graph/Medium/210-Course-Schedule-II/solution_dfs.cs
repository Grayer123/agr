public class Solution {
    public int[] FindOrder(int numCourses, int[,] prerequisites) {
        // dfs + hash table
        // tc:O(mn); sc:O(n)
        if(numCourses == 0) {
            return new int[0];
        }
        Dictionary<int, int> dict = new Dictionary<int, int>(); // record all the in-degree of node
        Dictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>(); // build the node with edges
        List<int> res = new List<int>();
        int sum = 0;
        for(int i = 0; i < prerequisites.GetLength(0); i++) {
            dict[prerequisites[i,0]] = dict.ContainsKey(prerequisites[i,0]) ? ++dict[prerequisites[i,0]] : 1; // calculate in-dgree
            if(graph.ContainsKey(prerequisites[i,1])) { //build the graph
                graph[prerequisites[i,1]].Add(prerequisites[i,0]);
            }
            else {
                graph[prerequisites[i,1]] = new List<int>{prerequisites[i,0]}; 
            }
        }    
        for(int i = 0; i < numCourses; i++) { // find all node with in-degree = 0
            if(!dict.ContainsKey(i)) {
                DFS(graph, dict, i, res, ref sum);
            }
        }
        return sum == numCourses ? res.ToArray() : new int[0];
    }
    
    private void DFS(Dictionary<int, IList<int>> graph, Dictionary<int, int> dict, int node, List<int> res, ref int sum) {
        sum++;
        res.Add(node);
        if(graph.ContainsKey(node)) {
            foreach(var nd in graph[node]) {
                dict[nd]--;
                if(dict[nd] == 0) {
                    DFS(graph, dict, nd, res, ref sum);
                }
            }
        }
    }
}