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
    public int FindBottomLeftValue(TreeNode root) {
        // bfs + level order traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            throw new Exception("Invalid input");
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int res = -1;
        while(queue.Count > 0) {
            int levelSize = queue.Count;
            for(int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                res = i == 0 ? node.val : res;
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
        }
        return res;
    }
}