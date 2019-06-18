/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node(){}
    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
}
*/
public class Solution {
    public Node TreeToDoublyList(Node root) {
        // inorder traversal; 
        // tc:O(n); sc:O(n)
        if(root == null) {
            return root;
        }
        Node prev = null, head = null;
        Inorder(root, ref prev, ref head);
        head.left = prev;
        prev.right = head;              
        return head;
    }
    
    private void Inorder(Node root, ref Node prev, ref Node head) {
        if(root == null) {
            return;
        }
        Inorder(root.left, ref prev, ref head);
        if(prev == null) { 
            head = root; 
        }
        else {
            root.left = prev; // prev is smaller than root
            prev.right = root;
        }
        prev = root; // keep tracking the current node
        Inorder(root.right, ref prev, ref head);
    }
}