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
    public IList<int> InorderTraversal(TreeNode root) {
        // iterative
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;
        while(cur != null || stack.Count > 0) {
            while(cur != null) { //put cur and its left children into stack
                stack.Push(cur);
                cur = cur.left;
            }
            var node = stack.Pop();
            res.Add(node.val);
            if(node.right != null) { // will add node.right at the beginning of while loop
                cur = node.right;
            }
        }
        return res;
    }
}