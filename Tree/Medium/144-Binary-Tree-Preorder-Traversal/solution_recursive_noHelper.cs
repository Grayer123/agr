/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

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

 // method 2: recursive: no add helper method
public class Solution {
    // dfs
    // tc:O(n); sc:O(n)
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null) {
            return new List<int>{};
        }
        
        var list = new List<int>();
        list.Add(root.val);
        
        var left = new List<int>(PreorderTraversal(root.left)); // method 1: convert IList to List
        //var left = PreorderTraversal(root.left) as List<int>;
        var right = PreorderTraversal(root.right) as List<int>; // method 2: convert IList to List
        
        list.AddRange(left);
        list.AddRange(right);
        
        return list;
    }
}