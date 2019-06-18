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
        // bfs: mimic level order traversal=>use the next pointer
        // tc:O(n); sc:O(1)
        if(root == null) {
            return root;
        }
        Node levelStart = root;
        while(levelStart != null) { // vertical access
            Node cur = levelStart;
            while(cur != null) { // horizontal access
                if(cur.left != null) {
                    cur.left.next = cur.right;
                }
                if(cur.right != null && cur.next != null) {
                    cur.right.next = cur.next.left;
                }
                cur = cur.next;
            }
            levelStart = levelStart.left;
        }
        return root;
    }
}