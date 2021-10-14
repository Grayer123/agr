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
        // iteration + stack
        // tc:O(n); sc:O(h)
        if (root == null) {
            return new List<int>();
        }
        
        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        
        while (root != null || stack.Count > 0) {
            // add all the left nodes to the stack, root == null at the end
            while (root != null) {
                stack.Push(root);
                root = root.left;
            }
            
            var node = stack.Pop();
            res.Add(node.val);
            
            // if right node is not null, then repeat the previous step to add all the left nodes
            if (node.right != null) {
                root = node.right;
            }
        }       
        return res;
    }
}
