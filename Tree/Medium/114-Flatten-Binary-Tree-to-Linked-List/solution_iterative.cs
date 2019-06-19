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
    public void Flatten(TreeNode root) {
        // iterative + stack + preorder traversal
        // tc:O(n); sc:O(h)
        if(root == null) {
            return;
        }
        TreeNode prev = null;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0) {
            TreeNode node = stack.Pop();
            if(node.right != null) {
                stack.Push(node.right);
            }
            if(node.left != null) {
                stack.Push(node.left);
            }
            if(prev != null) {
                prev.right = node;
                prev.left = null;
            }           
            prev = node;
        }
    }
}