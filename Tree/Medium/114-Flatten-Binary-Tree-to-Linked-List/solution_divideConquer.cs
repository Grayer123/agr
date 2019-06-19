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
        // traversal recursive
        // tc:O(n); sc:O(h)
        if(root == null) { // corner case 
            return;
        }
        TreeNode prev = null;
        DoFlatten(root, ref prev); // callee method reassign to prev => need to add ref 
    }
    
    private void DoFlatten(TreeNode node, ref TreeNode prev) {
        if(node == null) {
            return;
        }
        DoFlatten(node.right, ref prev);
        DoFlatten(node.left, ref prev);
        if(prev != null) {  // do flatten
            node.right = prev;
            node.left = null;
        }
        prev = node;
    }
}