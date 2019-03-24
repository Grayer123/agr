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
        // recursive bst property
        // tc:O(h); sc:O(1)
        if(root == null || p == null) { // corner case
            return root;
        }
        TreeNode res = null;
        FindInorderSuccessor(root, p, ref res);
        return res;
    }
    
    private void FindInorderSuccessor(TreeNode root, TreeNode p, ref TreeNode res) {
        if(root == null) {
            return;
        }
        if(root.val <= p.val) { // successor in the right subtree
            FindInorderSuccessor(root.right, p, ref res);
        }
        else {  // success could be ancestor or somenode in the left subtree
            res = root;
            FindInorderSuccessor(root.left, p, ref res);
        }
    }
}