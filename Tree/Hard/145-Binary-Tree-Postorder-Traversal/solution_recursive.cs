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
    public IList<int> PostorderTraversal(TreeNode root) {
        // recursive
        // tc:O(n); sc:O(h)
        if (root == null) {
            return new List<int>();
        }
        
        var left = PostorderTraversal(root.left) as List<int>;
        var right = PostorderTraversal(root.right);        
        
        left.AddRange(right);
        left.Add(root.val);
        
        return left;
    }
}