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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        // bfs + level order traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool shouldReverse = false;
        while(queue.Count > 0) {
            int levelSize = queue.Count;
            List<int> list = new List<int>();
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
            if(shouldReverse) {
                list.Reverse();
            }
            shouldReverse = !shouldReverse;
            res.Add(list);
        }
        return res;
    }
}