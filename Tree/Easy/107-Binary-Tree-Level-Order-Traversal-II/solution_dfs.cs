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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        List<IList<int>> res = new List<IList<int>>();
        MakeLevel(root, res, 1);
        res.Reverse();
        return res;
    }
    
    private void MakeLevel(TreeNode node, List<IList<int>> res, int height) {
        if(node == null) {
            return;
        }
        if(res.Count < height) {
            res.Add(new List<int>());
        }
        MakeLevel(node.left, res, height + 1);
        MakeLevel(node.right, res, height + 1);
        res[height - 1].Add(node.val);
    }
}