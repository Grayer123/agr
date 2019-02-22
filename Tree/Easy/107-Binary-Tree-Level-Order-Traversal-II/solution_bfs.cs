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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        // bfs + level order traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        List<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int levelSize = queue.Count;
            IList<int> list = new List<int>();
            for(int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                list.Add(node.val);
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            res.Add(list);
        }
        res.Reverse();
        return res;
    }
}