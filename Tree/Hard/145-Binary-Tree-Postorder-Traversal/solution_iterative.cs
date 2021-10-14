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
        // iteration + stack
        // tc:O(n); sc:O(n)
        if (root == null) {
            return new List<int>();
        }
        
        var res = new List<int>();
        var stack = new Stack<TreeNode>();        
        TreeNode lastVisited = null;
        
        while (root != null || stack.Count > 0) {
            while (root != null) { // put root and its left children into stack
                stack.Push(root);
                root = root.left;
            }
            var node = stack.Peek();
            
            if(node.right != null && node.right != lastVisited) { // node.right has never been visited
                root = node.right;
            }
            else { // either node.right == null or node.right has been visited
                res.Add(node.val);
                stack.Pop();
                lastVisited = node; // mark the current popped one as lastVisited
            }
        }
        return res;
    }
}
