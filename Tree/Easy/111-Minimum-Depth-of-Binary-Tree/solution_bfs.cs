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
    public int MinDepth(TreeNode root) {
        // bfs + level traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return 0;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int level = 0;
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int levelSize = queue.Count;  // get count of each level
            level++;
            for(int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                if(node.left == null && node.right == null) {
                    return level;
                }
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
        }
        return level;
    }
}