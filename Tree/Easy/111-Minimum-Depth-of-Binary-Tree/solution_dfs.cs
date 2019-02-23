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
    public int MinDepth(TreeNode root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return 0;
        }
        return FindMinHeight(root, 1);
    }
    
    private int FindMinHeight(TreeNode node, int height) {
        if(node.left == null && node.right == null) {
            return height;
        }
        if(node.left == null) {
            return FindMinHeight(node.right, height + 1);
        }
        if(node.right == null) {
            return FindMinHeight(node.left, height + 1);
        }
        return Math.Min(FindMinHeight(node.left, height + 1), FindMinHeight(node.right, height + 1));
    }
}