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
    public IList<int> InorderTraversal(TreeNode root) {
        // recursive
        // tc:O(n); sc:O(h)
        if (root == null) {
            return new List<int>();
        }
        
        var left = InorderTraversal(root.left) as List<int>;
        var right = InorderTraversal(root.right);
        
        left.Add(root.val);
        left.AddRange(right);
        
        return left;
    }
}
