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
        // recursive traversal inorder traversal
        // tc:O(n); sc:O(h)
        if(root == null) {
            throw new ArgumentException("Invalid input.");
        }
        TreeNode res = null;
        FindKth(root, ref k, ref res);
        if(res == null) {
            throw new ArgumentException("Invalid input."); // k > numOfNodes(tree)
        }
        return res.val;
    }
    
    private void FindKth(TreeNode node, ref int count, ref TreeNode res) {
        if(node == null) {
            return;
        }
        FindKth(node.left, ref count, ref res); // left, root, right => inorder traversal
        if(--count == 0) {
            res = node;
            return;
        }
        FindKth(node.right, ref count, ref res);
    }
}