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
    public int MaxDepth(TreeNode root) {
        // dfs 
        // tc:O(n); sc:O(n)
        if(root == null) {
            return 0;
        }
        return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
}