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
        // iterative + stack
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
       Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0) {
            var node = stack.Pop();
            res.Add(node.val);
            if(node.right != null) { // add right first then pop later
                stack.Push(node.right);
            }
            if(node.left != null) { // add left later then pop first
                stack.Push(node.left);
            }
        }
        return res;
    }
}