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

 // method 1: Add one private helper method to do the traversal.
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        // dfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<int>();
        }
        var res = new List<int>();
        Traverse(root, res);
        return res;
    }
    private void Traverse(TreeNode node, IList<int> res) {
        if(node == null) {
            return;
        }
        res.Add(node.val);
        Traverse(node.left, res);
        Traverse(node.right, res);
    }
}