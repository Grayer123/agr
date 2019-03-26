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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // iterative: bst property + lca
        // tc:O(h); sc:O(n)
        if(root == null || root == p || root == q) {
            return root;
        }
        while(root != null) {
            if(root.val > p.val && root.val > q.val) {
                root = root.left;
            }
            else if(root.val < p.val && root.val < q.val) {
                root = root.right;
            }
            else {
                return root;
            }
        }
        return null;
    }
}