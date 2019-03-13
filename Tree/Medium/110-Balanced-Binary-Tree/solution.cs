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
    
    // return -1 means not balanced binary tree
    private int GetHeight(TreeNode node) {
        if(node == null) {
            return 0;
        }
        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);
        if(leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1) {
            return -1;
        }
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}