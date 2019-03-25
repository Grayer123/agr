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
    public int ClosestValue(TreeNode root, double target) {
        // recursive BST property
        // tc:O(h); sc:O(1)
        if(root == null) {
            throw new ArgumentException("Invalid input");
        }
        TreeNode upper = null, lower = null;
        
        FindBound(root, target, ref upper, ref lower);
        if(upper == null) {
            return lower.val;
        }
        if(lower == null) {
            return upper.val;
        }
        return upper.val - target < target - lower.val ? upper.val : lower.val;
    }
    private void FindBound(TreeNode root, double target, ref TreeNode upper, ref TreeNode lower) {
        if(root == null) {
            return;
        }
        if(root.val < target) {
            lower = root;
            FindBound(root.right, target, ref upper, ref lower);
        }
        else {
            upper = root;
            FindBound(root.left, target, ref upper, ref lower);
        }
    }
}