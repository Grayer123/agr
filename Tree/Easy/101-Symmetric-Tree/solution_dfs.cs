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
    public bool IsSymmetric(TreeNode root) {
        // dfs: level order traversal
        if(root == null) {
            return true;
        }
        TreeNode left = root.left;
        TreeNode right = root.right;
        return Compare(left, right);
        
    }
    private bool Compare(TreeNode left, TreeNode right) {
        if(left == null && right == null) {
            return true;
        }
        if((left == null) != (right == null)) {
            return false;
        }
        return left.val == right.val && Compare(left.left, right.right) && Compare(left.right, right.left);
    }
}