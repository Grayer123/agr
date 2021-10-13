/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// Version 1: Global Variable
public class Solution {
    // initiate the maxSum as the MinValue of int
    private int maxSum = Int32.MinValue;
    
    public int MaxPathSum(TreeNode root) {
        // recursive
        // TC: O(n); SC: O(h)
        if (root == null) {
            return 0;
        }
        
        GetMaxOnOneSide(root);
        
        return maxSum;
    }
    
    private int GetMaxOnOneSide(TreeNode node) {
        if (node == null) {
            return 0;
        }
        
        // value < 0 would not contribute to the max path
        var left = Math.Max(GetMaxOnOneSide(node.left), 0);
        var right = Math.Max(GetMaxOnOneSide(node.right), 0);
        
        // start a new path with current node as the root (highest node)
        int priceNewPath = node.val + left + right;
        maxSum = Math.Max(maxSum, priceNewPath);
        
        // for recursion: return the max gain if continue the same path from bottom to top
        return node.val + Math.Max(left, right);
    }
}