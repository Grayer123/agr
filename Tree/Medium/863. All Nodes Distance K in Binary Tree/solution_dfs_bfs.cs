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
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K) {
        // hash table + dfs + bfs
        // tc:O(n); sc:O(n)
        if(root == null || target == null || K < 0) {
            return new List<int>();
        }
        if(K == 0) {
            return new List<int>{target.val};
        }
        Dictionary<TreeNode, TreeNode> parents = new Dictionary<TreeNode, TreeNode>(); // store the node to parent relationship
        LookupParent(root, parents);
        IList<int> res = new List<int>();
        HashSet<TreeNode> visited = new HashSet<TreeNode>(); // extending two directions, so need hashset to mark visited
        Queue<TreeNode> queue = new Queue<TreeNode>(); // queue used for bfs
        queue.Enqueue(target);
        FindDistanceK(queue, parents, visited, res, K);
        return res;
        
    }
    
    private void FindDistanceK(Queue<TreeNode> queue, Dictionary<TreeNode, TreeNode> parents, HashSet<TreeNode> visited, IList<int> res, int k) { // bfs
        int level = 0;
        while(queue.Count > 0 && level <= k) {
            int levelSize = queue.Count;
            for(int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                if(level == k) {
                    res.Add(node.val);
                    continue;
                }
                visited.Add(node);
                if(parents.ContainsKey(node) && !visited.Contains(parents[node])) { // move up to parent
                    queue.Enqueue(parents[node]);
                }
                if(node.left != null && !visited.Contains(node.left)) { // move down to left
                    queue.Enqueue(node.left);
                }
                if(node.right != null && !visited.Contains(node.right)) { // move down to right
                    queue.Enqueue(node.right);
                }
            }
            level++;
        }
    }
    
    private void LookupParent(TreeNode root, Dictionary<TreeNode, TreeNode> parents) { // build the parent map
        if(root == null) {
            return;
        }
        if(root.left != null) {
            parents[root.left] = root;
        }
        if(root.right != null) {
            parents[root.right] = root;
        }
        LookupParent(root.left, parents);
        LookupParent(root.right, parents);
    }
}