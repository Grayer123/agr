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
        // dfs + binary tree + findMaxHeight + leftMost node
        // tc:O(n); sc:O(n)
        if(root == null) {
            throw new Exception("invalid input");
        }
        int res = -1;
        int maxHeight = -1;
        Dfs(root, 0, ref maxHeight, ref res);
        return res;
    }
    
    private void Dfs(TreeNode node, int curHeight, ref int maxHeight, ref int res) {
        if(node == null) {
            return;
        }
        if(curHeight > maxHeight) {
            res = node.val;
            maxHeight = curHeight;
        }
        Dfs(node.left, curHeight + 1, ref maxHeight, ref res);
        Dfs(node.right, curHeight + 1, ref maxHeight, ref res);
    }
}