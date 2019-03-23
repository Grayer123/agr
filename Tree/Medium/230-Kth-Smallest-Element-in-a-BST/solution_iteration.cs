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
    public int KthSmallest(TreeNode root, int k) {
        // iterative inorder traversal
        // tc:O(n); sc:O(h)
        if(root == null) {
            throw new ArgumentException("Invalid input.");
        }
        Stack<TreeNode> stack = new Stack<TreeNode>();
        int count = 0;
        TreeNode cur = root;
        while(cur != null || stack.Count > 0) {
            while(cur != null) {
                stack.Push(cur);
                cur = cur.left;
            }
            TreeNode node = stack.Pop();
            count++;
            if(count == k) {
                return node.val;
            }
            if(node.right != null) {
                cur = node.right;
            }
        }
        throw new ArgumentException("Invalid input.");
    }
}