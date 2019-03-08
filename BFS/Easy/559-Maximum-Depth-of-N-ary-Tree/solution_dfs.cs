/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public int MaxDepth(Node root) {
        // bfs + level traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return 0;
        }
        Queue<Node> queue = new Queue<Node>();
        int level = 0;
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int levelSize = queue.Count;  // get count of each level
            level++;
            for(int i = 0; i < levelSize; i++) {
                Node node = queue.Dequeue();
                foreach(var child in node.children) {
                    if(child != null) {
                        queue.Enqueue(child);
                    }
                }
            }
        }
        return level;
    }
}