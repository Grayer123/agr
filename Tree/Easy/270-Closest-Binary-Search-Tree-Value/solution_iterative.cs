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
    public int ClosestValue(TreeNode root, double target) {
        // iterative BST property
        // tc:O(h); sc:O(1)
        if(root == null) {
            throw new ArgumentException("Invalid input");
        }
        TreeNode upper = null, lower = null;
        
        while(root != null) {
            if(root.val < target) {
                lower = root;
                root = root.right;
            }
            else if(root.val == target) {
                return root.val;
            }
            else { 
                upper = root;
                root = root.left;
            }
        }
        if(upper == null) {
            return lower.val;
        }
        if(lower == null) {
            return upper.val;
        }
        return upper.val - target < target - lower.val ? upper.val : lower.val;
    }
}