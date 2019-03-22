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
        // iterative + preorder traversal
        // tc:O(n); sc:O(h)
        if(root == null) {
            return;
        }
        TreeNode lastNode = null;
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
            if(lastNode != null) {
                lastNode.right = node;
                lastNode.left = null;
            }           
            lastNode = node;
        }
    }
}