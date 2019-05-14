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
        // level order traversal; bfs
        // tc:O(n); sc:O(n)
        if(root == null) {
            return new List<IList<int>>();
        }
        IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool leftToRight = true;
        while(queue.Count > 0) {
            int rowSize = queue.Count;
            List<int> list = new List<int>();
            for(int i = 0; i < rowSize; i++) {
                TreeNode node = queue.Dequeue();
                list.Add(node.val);
                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            if(!leftToRight) {
                list.Reverse();
            }
            leftToRight = !leftToRight;
            res.Add(list);
        }
        return res;
    }
}