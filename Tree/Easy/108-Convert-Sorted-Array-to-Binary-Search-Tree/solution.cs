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
    public TreeNode SortedArrayToBST(int[] nums) {
        // divide and conquer
        // tc:O(n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            return null;
        }
        return BuildTree(nums, 0, nums.Length - 1);
    }
    
    private TreeNode BuildTree(int[] nums, int start, int end) {
        if(start > end) {
            return null;
        }
        int mid = start + (end - start) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = BuildTree(nums, start, mid - 1);
        root.right = BuildTree(nums, mid + 1, end);
        return root;
    }
}