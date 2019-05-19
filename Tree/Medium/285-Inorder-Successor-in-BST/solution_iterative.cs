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
        // bst property; iterative
        // tc:O(h); sc:O(1)
        if(root == null || p == null) { //corner case
            return null;
        }
        TreeNode successor = null;
        while(root != null) {
            if(root.val <= p.val) { // successor in the right subtree
                root = root.right;
            }
            else { // success could be ancestor or somenode in the left subtree
                successor = root;
                root = root.left;
            }
        }
        return successor;
    }
}