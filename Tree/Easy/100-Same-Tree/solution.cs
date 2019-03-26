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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // preorder traversal
        // tc:O(n); sc:O(n)
        if(p == null && q == null) {
            return true;
        }
        if((p == null) != (q == null)) { // one of p, q is null
            return false;
        }
        if(p.val != q.val) {
            return false;
        }
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}