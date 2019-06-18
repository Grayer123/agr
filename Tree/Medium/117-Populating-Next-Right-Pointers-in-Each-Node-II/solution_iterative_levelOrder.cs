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
        Node parent = root;
        while(parent != null) { // vertical access
            Node childHead = null; // maintain the head of the next (child) layer
            Node child = null;  // keep tracking the current child node (move to right most)
            while(parent != null) { // horizontal access
                if(parent.left != null) {
                    if(childHead == null) {
                        childHead = parent.left;
                    }
                    else {
                        child.next = parent.left;
                    }
                    child = parent.left;
                }
                if(parent.right != null) {
                    if(childHead == null) {
                        childHead = parent.right;
                    }
                    else {
                        child.next = parent.right;
                    }
                    child = parent.right;
                }
                parent = parent.next; // horizontal move
            }
            parent = childHead; // vertical move
        }
        return root;
    }
}