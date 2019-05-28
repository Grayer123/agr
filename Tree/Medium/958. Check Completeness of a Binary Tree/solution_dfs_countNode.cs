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
        // dfs: node count
        // tc:O(n); sc:O(n)
        if(root == null) {
            return true;
        }
        int count = 0, max = 0;
        CountNode(root, 1, ref count, ref max);
        return count == max; // the count of the whole tree should match the furthest node index
    }
    
    private void CountNode(TreeNode node, int index, ref int count, ref int max) {
        if(node == null) {
            return;
        }
        count++;
        max = Math.Max(max, index);
        CountNode(node.left, index * 2, ref count, ref max);
        CountNode(node.right, index * 2 + 1, ref count, ref max);
    }
}