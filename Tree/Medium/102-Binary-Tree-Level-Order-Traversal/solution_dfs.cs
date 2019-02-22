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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        // dfs => use dfs to build level and add node to each level
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        List<IList<int>> res = new List<IList<int>>();
        MakeLevel(root, res, 0);
        return res;
    }
    
    private void MakeLevel(TreeNode node, List<IList<int>> res, int height) {
        if(node == null) {
            return;
        }
        if(res.Count <= height) {
            res.Add(new List<int>());
        } 
        res[height].Add(node.val);
        MakeLevel(node.left, res, height + 1);
        MakeLevel(node.right, res, height + 1);
    } 
}