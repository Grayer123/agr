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
    public bool IsValidBST(TreeNode root) {
        // divide and conquer
        // tc:O(n); sc:O(n)
        if(root == null) { // corner case
            return true;
        }
        return Dfs(root, Int64.MaxValue, Int64.MinValue);
    }
    
    private bool Dfs(TreeNode node, long max, long min) {
        if(node == null) { // corner case
            return true;
        }
        if(node.val >= max || node.val <= min) {
            return false;
        }
        return Dfs(node.left, node.val, min) && Dfs(node.right, max, node.val);
    }
    
}