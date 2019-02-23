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
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        List<IList<int>> res = new List<IList<int>>();
        MakeLevel(root, res, 0);
        return res;
    }
    
    private void MakeLevel(Node node, List<IList<int>> res, int height) {
        if(node == null) {
            return;
        }
        if(res.Count <= height) { //make entry in res
            res.Add(new List<int>());
        }
        foreach(var nd in node.children) { // add all children
            MakeLevel(nd, res, height + 1);
        }
        res[height].Add(node.val);
    }
}