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
    public TreeNode InvertTree(TreeNode root) {
        // divide and conquer
        // tc:O(n); sc:O(h)
        if(root == null) {
            return root;
        }
        TreeNode left = InvertTree(root.left);
        TreeNode right = InvertTree(root.right);
        TreeNode tmp = left;
        root.left = right;
        root.right = left;
        return root;
    }
}