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
        TreeNode lastNode = null;
        DoFlatten(root, ref lastNode); // callee method reassign to lastNode => need to add ref 
    }
    
    private void DoFlatten(TreeNode node, ref TreeNode lastNode) {
        if(node == null) {
            return;
        }
        if(lastNode != null) { // do flatten
            lastNode.right = node;
            lastNode.left = null;           
        }
        lastNode = node; // keep the last visited node 
        TreeNode right = node.right; // node.right will reassign, keep the copy
        DoFlatten(node.left, ref lastNode);
        DoFlatten(right, ref lastNode);
    }
}