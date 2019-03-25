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
    public IList<int> ClosestKValues(TreeNode root, double target, int k) {
        // inorder traversal
        // tc:O(h + k); sc:O(h)
        if(root == null || k <= 0) { // corner case
            return new List<int>();
        }
        Stack<TreeNode> upper = new Stack<TreeNode>();
        Stack<TreeNode> lower = new Stack<TreeNode>();
        GetSuccessor(root, target, upper);  // get initial closest larger elem, stack stores the path to get to the elem
        GetPredecessor(root, target, lower); // get initial closest smaller elem, stack stores the path to get to the elem
        
        IList<int> res = new List<int>();
        while(res.Count < k) {
            if(lower.Count == 0 || upper.Count > 0 && upper.Peek().val - target <= target - lower.Peek().val) {
                TreeNode node = upper.Pop();
                res.Add(node.val);
                GetSuccessor(node.right, target, upper); // get the next larger elem
            }
            else if(upper.Count == 0 || lower.Count > 0 && upper.Peek().val - target > target - lower.Peek().val) {
                TreeNode node = lower.Pop();
                res.Add(node.val);
                GetPredecessor(node.left, target, lower);  // get the next smaller elem
            }
        }
        return res;
    }
    
    private void GetSuccessor(TreeNode node, double target, Stack<TreeNode> upper) { // get the next larger node to target
        while(node != null) { // stack stores the path to get the closest larger elem
            if(node.val >= target) {
                upper.Push(node);
                node = node.left;
            }
            else {
                node = node.right;
            }
        }
    }
    
    private void GetPredecessor(TreeNode node, double target, Stack<TreeNode> lower) { // get the next smaller node to target
        while(node != null) { // stack stores the path to get the closest smaller elem
            if(node.val < target) {
                lower.Push(node);
                node = node.right;
            }
            else {
                node = node.left;
            }
        }
    } 
}