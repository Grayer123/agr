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
    public IList<int> PreorderTraversal(TreeNode root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
        Dfs(root, res);
        return res;
    }
    private void Dfs(TreeNode node, IList<int> res) {
        if(node == null) {
            return;
        }
        res.Add(node.val);
        Dfs(node.left, res);
        Dfs(node.right, res);
    }
}