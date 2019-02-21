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
    public bool IsSymmetric(TreeNode root) {
        // bfs + simulate
        // tc:O(n); sc:O(n)
        if(root == null) {
            return true;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        while(queue.Count > 0) {
            TreeNode node1 = queue.Dequeue();
            TreeNode node2 = queue.Dequeue();
            if(node1 == null && node2 == null) {
                continue;
            }
            if(node1 == null || node2 == null) {
                return false;
            }
            if(node1.val != node2.val) {
                return false;
            }
            queue.Enqueue(node1.left);
            queue.Enqueue(node2.right); // these 2 as a compare pair
            queue.Enqueue(node1.right);
            queue.Enqueue(node2.left); // these 2 as another compare pair
        }
        return true;
    }
}