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
    public bool HasPathSum(TreeNode root, int sum) {
        // divide and conquer
        // TC:O(n); SC:O(h)
        if(root == null) { // corner case
            return false;
        }
        return FindSumPath(root, sum, 0);
    }
    
    private bool FindSumPath(TreeNode node, int target, int pathSum) {
        if(node == null) {
            return false;
        }
        pathSum += node.val;
        if(node.left == null && node.right == null) { // leaf node
            return pathSum == target;
        }
        return FindSumPath(node.left, target, pathSum) || FindSumPath(node.right, target, pathSum);
    }
}