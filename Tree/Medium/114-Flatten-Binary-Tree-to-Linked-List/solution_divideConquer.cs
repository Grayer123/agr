/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void Flatten(TreeNode root) {
        // divide and conquer
        // tc:O(n); sc:O(h)
        if(root == null) { // corner case
            return;
        }
        DoFlatten(root);
    }
    
    private TreeNode DoFlatten(TreeNode node) { //return last visited node 
        if(node == null) {
            return null;
        }
        TreeNode lastLeft = DoFlatten(node.left); // flatten left subtree
        TreeNode lastRight = DoFlatten(node.right); // flatten right subtree
        if(lastLeft != null) { // connect left subtree and right subtree
            lastLeft.right = node.right;
            node.right = node.left;
            node.left = null;
        }
        if(lastRight != null) { //return last visited node
            return lastRight;
        }
        if(lastLeft != null) {
            return lastLeft;
        }
        return node;
    }
}