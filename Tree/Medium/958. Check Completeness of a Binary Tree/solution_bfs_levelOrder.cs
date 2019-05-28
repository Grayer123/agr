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
    public bool IsCompleteTree(TreeNode root) {
        // bfs: level order traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return true;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Peek() != null) {  // find the first null node
            TreeNode node = queue.Dequeue();
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }
        while(queue.Count > 0 && queue.Peek() == null) { // complete tree: should be empty after the first null node
            queue.Dequeue();
        }
        return !(queue.Count > 0);
    }
}