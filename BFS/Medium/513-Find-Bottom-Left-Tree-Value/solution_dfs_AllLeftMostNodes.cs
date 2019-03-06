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
    public int FindBottomLeftValue(TreeNode root) {
        // dfs + binary tree + keep all leftmost nodes in all level
        // tc:O(n); sc:O(n)
        if(root == null) {
            throw new Exception("invalid input");
        }
        List<int> res = new List<int>();
        Dfs(root, 0, res);
        return res[res.Count - 1];
    }
    
    private void Dfs(TreeNode node, int height, List<int> res) {
        if(node == null) {
            return;
        }
        if(res.Count <= height) {
            res.Add(node.val);
        }
        Dfs(node.left, height + 1, res);
        Dfs(node.right, height + 1, res);
    }
}