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
    public IList<IList<int>> LevelOrder(Node root) {
        // bfs + level traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        Queue<Node> queue = new Queue<Node>();
        List<IList<int>> res = new List<IList<int>>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int levelSize = queue.Count;  // get count of each level
            List<int> row = new List<int>();
            for(int i = 0; i < levelSize; i++) {
                Node node = queue.Dequeue();
                row.Add(node.val);
                foreach(var nd in node.children) { // enqueue all the children of current node
                    queue.Enqueue(nd);
                }
            }
            res.Add(row);
        }
        return res;
    }
}