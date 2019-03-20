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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        // divide and conquer
        // TC:O(n); SC:O(h)
        if(root == null) { // corner case
            return new List<IList<int>>();
        }
        List<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        FindSumPath(root, sum, 0, res, path); 
        return res;
    }
    
    private void FindSumPath(TreeNode node, int target, int pathSum, List<IList<int>> res, List<int> path) {
        if(node == null) {
            return;
        }
        pathSum += node.val;
        path.Add(node.val);
        if(node.left == null && node.right == null && pathSum == target) { // leaf node
            res.Add(new List<int>(path));
            path.RemoveAt(path.Count - 1); // remove the leaf node => as it returns, not go to child node
            return;
        }
        FindSumPath(node.left, target, pathSum, res, path);        
        FindSumPath(node.right, target, pathSum, res, path);
        path.RemoveAt(path.Count - 1); // remove the current node
    }
}