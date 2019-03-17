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
    public bool IsValidBST(TreeNode root) {
        // divide and conquer; bst
        // tc:O(n); sc:O(n)
        if(root == null) {
            return true;
        }
        return ValidateBST(root, Int64.MinValue, Int64.MaxValue);
    }
    private bool ValidateBST(TreeNode node, long min, long max) {
        if(node == null) {
            return true;
        }
        if(node.val <= min || node.val >= max) { // not a valid bst
            return false;
        }
        return ValidateBST(node.left, min, node.val) && ValidateBST(node.right, node.val, max);
    }
}