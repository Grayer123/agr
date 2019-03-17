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
    public bool IsBalanced(TreeNode root) {
        // divide and conquer
        // tc:O(n); sc:O(n)
        if(root == null) {
            return true;
        }
        return GetHeight(root) != -1;
    }
    // return -1 if not balanced; otherwise return the height of current node
    private int GetHeight(TreeNode node) {
        if(node == null) {
            return 0;
        }
        int left = GetHeight(node.left);
        int right = GetHeight(node.right);
        if(left == -1 || right == -1 || Math.Abs(left - right) > 1) {
            return -1;  // not balanced
        }
        return Math.Max(left, right) + 1;
    }
}