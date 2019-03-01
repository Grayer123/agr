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
    public IList<int> RightSideView(TreeNode root) {
        // bfs + level order traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int levelSize = queue.Count;
            for(int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                if(i == 0) {
                    res.Add(node.val);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
            }
        }
        return res;
    }
}