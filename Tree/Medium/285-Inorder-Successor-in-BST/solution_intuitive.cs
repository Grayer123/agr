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
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        // recursive inorder traversal
        // tc:O(n); sc:O(h)
        if(root == null || p == null) {
            return root;
        }
        TreeNode lastNode = null;
        return InorderTraverse(root, ref lastNode, p);
    }
    private TreeNode InorderTraverse(TreeNode root, ref TreeNode lastNode, TreeNode target) {
        if(root == null) {
            return null;
        }
        TreeNode left = InorderTraverse(root.left, ref lastNode, target);
        if(left != null) {
            return left;
        }
        if(lastNode == target) {
            return root;
        }
        lastNode = root;
        TreeNode right = InorderTraverse(root.right, ref lastNode, target);
        if(right != null) {
            return right;
        }
        return null;
    }
}