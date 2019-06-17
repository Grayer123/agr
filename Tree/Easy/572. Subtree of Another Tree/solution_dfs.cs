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
    public bool IsSubtree(TreeNode s, TreeNode t) {
        // dfs 
        // tc:O(m * n); sc:O(n)
        if(t == null) {
            return true;
        }
        if(s == null) {
            return false;
        }
        bool left = IsSubtree(s.left, t);
        bool right = IsSubtree(s.right, t);
        if(left || right) {
            return true;
        }
        return CheckSameTree(s, t);
        
    }
    
    private bool CheckSameTree(TreeNode s, TreeNode t) {
        if(s == null && t == null) {
            return true;
        }
        if(s == null || t == null) {
            return false;
        }
        return s.val == t.val && CheckSameTree(s.left, t.left) && CheckSameTree(s.right, t.right);
    }
}