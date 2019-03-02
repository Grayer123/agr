public class Solution {
    public string AlienOrder(string[] words) {
        // bfs + topological sort
        // tc:O(n); sc:O(n)
        if(words == null) {
            return String.Empty;
        }
        Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();
        Dictionary<char, int> inBounds = new Dictionary<char, int>();
        string prev = words[0];
        for(int i = 0; i < words.Length; i++) { // build the graph
            bool isDifferent = false;
            for(int j = 0; j < words[i].Length; j++) {
                if(!graph.ContainsKey(words[i][j])) { // build the node
                    graph[words[i][j]] = new List<char>();
                    inBounds[words[i][j]] = 0;
                }
                if(!isDifferent && j < prev.Length && words[i][j] != prev[j]) { // build the edge
                    graph[prev[j]].Add(words[i][j]);
                    inBounds[words[i][j]]++;     // build the in-bounds
                    isDifferent = true;
                }
            }
            prev = words[i];
        }
        Queue<char> queue = new Queue<char>();
        foreach(char ch in inBounds.Keys) {
            if(inBounds[ch] == 0) { // add all nodes with in-bound = 0 to queue
                queue.Enqueue(ch);
            }
        }
        StringBuilder str = new StringBuilder();
        while(queue.Count > 0) {
            char ch = queue.Dequeue();
            str.Append(ch);
            foreach(var ngb in graph[ch]) {
                inBounds[ngb]--;
                if(inBounds[ngb] == 0) {
                    queue.Enqueue(ngb);
                }
            }
        }
        return str.Length == graph.Count ? str.ToString() : String.Empty;
    }
}