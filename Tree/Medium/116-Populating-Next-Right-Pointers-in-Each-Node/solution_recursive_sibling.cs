/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(){}
    public Node(int _val,Node _left,Node _right,Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
}
*/
public class Solution {
    public Node Connect(Node root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return root;
        }
        ConnectWithSibling(root, null);
        return root;
    }
    
    private void ConnectWithSibling(Node node, Node sibling) {
        if(node == null) {
            return;
        }
        node.next = sibling;
        ConnectWithSibling(node.left, node.right);
        ConnectWithSibling(node.right, sibling == null ? sibling : sibling.left);
    }
}