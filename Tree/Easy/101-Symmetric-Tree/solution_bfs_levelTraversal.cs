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
        // bfs: level order traversal
        if(root == null) {
            return true;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            int levelSize = queue.Count;
            IList<int> list = new List<int>();
            for(int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                if(node.left != null) {
                    queue.Enqueue(node.left);
                    list.Add(node.left.val);
                }
                else {
                    list.Add(0);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                    list.Add(node.right.val);
                }
                else {
                    list.Add(0);
                }
                
            }
            if(!IsLevelSymmetric(list)) {
                return false;
            }
        }
        return true;
    }
    private bool IsLevelSymmetric(IList<int> list) {
        int left = 0, right = list.Count - 1;
        while(left < right) {
            if(list[left] != list[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}