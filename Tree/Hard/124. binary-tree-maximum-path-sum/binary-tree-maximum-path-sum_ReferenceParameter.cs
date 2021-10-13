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
 
 // Version 2: Reference Type Paramater
public class Solution {
    public int MaxPathSum(TreeNode root) {
        // binary tree; recursive
        // TC: O(n); SC: O(h)
        if (root == null) {
            return 0;
        }
        
        // initiate the maxSum as the MinValue of int
        int maxSum = Int32.MinValue;
        GetOneBranchMax(root, ref maxSum);
        
        return maxSum;
    }
    
    // reference type parameter
    private int GetOneBranchMax(TreeNode node, ref int maxSum) {
        if (node == null) {
            return 0;
        }
        
        // value < 0 would not contribute to the max path
        int left = Math.Max(GetOneBranchMax(node.left, ref maxSum), 0);
        int right = Math.Max(GetOneBranchMax(node.right, ref maxSum), 0);
        
        // start a new path with current node as the root (highest node)
        int priceNewPath = node.val + left + right;
        maxSum = Math.Max(maxSum, priceNewPath);

        // for recursion: return the max gain if continue the same path from bottom to top
        return node.val + Math.Max(left, right);
    }
}
