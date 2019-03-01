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
    public IList<int> RightSideView(TreeNode root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<int>();
        }
        List<int> res = new List<int>();
        Dfs(root, res, 0);
        return res;
    }
    private void Dfs(TreeNode node, List<int> res, int level) {
        if(node == null) {
            return;
        }
        if(res.Count <= level) {
            res.Add(node.val);
        }
        Dfs(node.right, res, level + 1);
        Dfs(node.left, res, level + 1);
    }
}