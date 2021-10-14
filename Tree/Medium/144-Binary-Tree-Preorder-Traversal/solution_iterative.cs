/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        // iteration + stack
        // tc:O(n); sc:O(h)
        if (root == null) {
            return new List<int>();
        }
        
        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.Count > 0) {
            var node = stack.Pop();
            res.Add(node.val);
            
            // since stack is FILO, so put in right first, and it would be popped last
            if (node.right != null) {
                stack.Push(node.right);
            }
            
            if (node.left != null) {
                stack.Push(node.left);
            }
        }
        
        return res;
    }
    
}