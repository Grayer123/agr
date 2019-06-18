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
    public int MaxAncestorDiff(TreeNode root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            throw new ArgumentException("Invalid input.");
        }
        int maxDiff = 0;
        FindMaxDiff(root, root.val, root.val, ref maxDiff);
        return maxDiff;
        
    }
    private void FindMaxDiff(TreeNode node, int max, int min, ref int maxDiff) {
        if(node == null) {
            return;
        }
        int diff = Math.Max(Math.Abs(node.val - max), Math.Abs(node.val - min));
        maxDiff = Math.Max(maxDiff, diff);
        max = Math.Max(max, node.val);
        min = Math.Min(min, node.val);
        FindMaxDiff(node.left, max, min, ref maxDiff);
        FindMaxDiff(node.right, max, min, ref maxDiff);
    }
}