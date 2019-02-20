/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        //bfs + hashtable
        // tc:O(node * edge); sc:O(n)
        if(node == null) {
            return node;
        }
        Dictionary<UndirectedGraphNode, UndirectedGraphNode> dict = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
        Queue<UndirectedGraphNode> queue = new Queue<UndirectedGraphNode>();
        queue.Enqueue(node);
        dict[node] = new UndirectedGraphNode(node.label);
        while(queue.Count > 0) {
            var nd = queue.Dequeue();      
            foreach(var neigh in nd.neighbors) { // for all neighbors of the current node 
                if(!dict.ContainsKey(neigh)) { // clone node of current does not exist
                    dict[neigh] =  new UndirectedGraphNode(neigh.label); // create new clone node
                    queue.Enqueue(neigh); // add node has not been accessed
                }
                dict[nd].neighbors.Add(dict[neigh]);
            }
        }
        return dict[node];
    }
}