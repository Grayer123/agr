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
        //dfs + hashtable
        // tc:O(node * edge); sc:O(n)
        if(node == null) {
            return node;
        }
        Dictionary<UndirectedGraphNode, UndirectedGraphNode> dict = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
        return CloneNode(node, dict);
    }
    
    private UndirectedGraphNode CloneNode(UndirectedGraphNode node, Dictionary<UndirectedGraphNode, UndirectedGraphNode> dict) {
        dict[node] = new UndirectedGraphNode(node.label);
        foreach(var nd in node.neighbors) {
            if(!dict.ContainsKey(nd)) {
                CloneNode(nd, dict);
            }
            dict[node].neighbors.Add(dict[nd]);
        }
        return dict[node];
    }
}