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
    public class ResultType {
        public bool isBalanced;
        public int depth;
        
        public ResultType(int depth, bool balanced) {
            this.depth = depth;
            this.isBalanced = balanced;
        }
    }
    
    public bool IsBalanced(TreeNode root) {
        // divide and conquer
        // tc:O(n); sc:O(n)
        if(root == null) {
            return true;
        }
        return GetHeight(root).isBalanced;
    }
    
    // return -1 means not balanced binary tree
    private ResultType GetHeight(TreeNode node) {
        if(node == null) {
            return new ResultType(0, true);
        }
        var left = GetHeight(node.left);
        var right = GetHeight(node.right);
        if(!left.isBalanced || !right.isBalanced || Math.Abs(left.depth - right.depth) > 1) {
            return new ResultType(-1, false);
        }
        return new ResultType(Math.Max(left.depth, right.depth) + 1, true);
    }
}