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
        // bst property; recursive
        // tc:O(h); sc:O(h)
        if(root == null || p == null) { //corner case
            return null;
        }
        if(root.val <= p.val) {
            return InorderSuccessor(root.right, p);
        }
        // root.val > p.val
        TreeNode successor = InorderSuccessor(root.left, p);
        return successor != null ? successor : root;
    }
}