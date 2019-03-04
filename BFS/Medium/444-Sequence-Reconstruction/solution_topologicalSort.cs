public class Solution {
    public bool SequenceReconstruction(int[] org, IList<IList<int>> seqs) {
        // bfs + topological sorting
        // tc:O(m*n); sc:O(m*n)
        Dictionary<int, List<int>> graph = ConstructGraph(seqs);
        Dictionary<int, int> inBounds = CalculateInBounds(graph);
        Queue<int> queue = new Queue<int>();
        foreach(var node in graph.Keys) {
            if(!inBounds.ContainsKey(node)) { // find all the nodes with in-bound = 0
                queue.Enqueue(node); 
            }
        }
        List<int> res = new List<int>();
        while(queue.Count > 0) { // only one topological sorting => queue.Count==1 => no need level traversal
            if(queue.Count > 1) { // could be more than one topological sorting sequence 
                return false;
            }
            int node = queue.Dequeue();
            res.Add(node);
            foreach(var ngb in graph[node]) {
                inBounds[ngb]--;
                if(inBounds[ngb] == 0) {
                    queue.Enqueue(ngb);
                }
            }
        }
        if(res.Count != graph.Count || res.Count != org.Length) { // res.Count != graph.Count => might be cycle in the graph
            return false;
        }
        return CompareResult(res, org);
        
    }
    private Dictionary<int, List<int>> ConstructGraph(IList<IList<int>> seqs) {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        foreach(var list in seqs) {
            for(int i = 0; i < list.Count; i++) {
                if(!graph.ContainsKey(list[i])) {
                    graph[list[i]] = new List<int>(); // create node
                }
                if(i + 1 < list.Count) {
                    graph[list[i]].Add(list[i + 1]); // create edge
                }
            }
        }
        return graph;
    }
    
    private Dictionary<int, int> CalculateInBounds(Dictionary<int, List<int>> graph) {
        Dictionary<int, int> inBounds = new Dictionary<int, int>();
        foreach(var node in graph.Keys) {
            foreach(var ngb in graph[node]) {
                inBounds[ngb] = inBounds.ContainsKey(ngb) ? ++inBounds[ngb] : 1;
            }
        }
        return inBounds;
    }
    
    private bool CompareResult(List<int> list, int[] org) {
        for(int i = 0; i < list.Count; i++) {
            if(list[i] != org[i]) {
                return false;
            }
        }
        return true;
    }
}