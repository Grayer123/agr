/*
 * @lc app=leetcode id=437 lang=csharp
 *
 * [437] Path Sum III
 *
 * https://leetcode.com/problems/path-sum-iii/description/
 *
 * algorithms
 * Easy (42.06%)
 * Total Accepted:    95.3K
 * Total Submissions: 226.5K
 * Testcase Example:  '[10,5,-3,3,2,null,11,3,-2,null,1]\n8'
 *
 * You are given a binary tree in which each node contains an integer value.
 * 
 * Find the number of paths that sum to a given value.
 * 
 * The path does not need to start or end at the root or a leaf, but it must go
 * downwards
 * (traveling only from parent nodes to child nodes).
 * 
 * The tree has no more than 1,000 nodes and the values are in the range
 * -1,000,000 to 1,000,000.
 * 
 * Example:
 * 
 * root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8
 * 
 * ⁠     10
 * ⁠    /  \
 * ⁠   5   -3
 * ⁠  / \    \
 * ⁠ 3   2   11
 * ⁠/ \   \
 * 3  -2   1
 * 
 * Return 3. The paths that sum to 8 are:
 * 
 * 1.  5 -> 3
 * 2.  5 -> 2 -> 1
 * 3. -3 -> 11
 * 
 * 
 */
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
    public int PathSum(TreeNode root, int sum) {
        // divide and conquer
        // TC:O(n); SC:O(n)
        if(root == null) {
            return 0;
        }
        int res = 0;
        List<int> pathSum = new List<int>();
        FindPaths(root, pathSum, sum, ref res);
        return res;
    }
    
    private void FindPaths(TreeNode node, List<int> pathSum, int sum, ref int res) {
        if(node == null) {
            return;
        }
        for(int i = 0; i < pathSum.Count; i++) {
            pathSum[i] += node.val;
            if(pathSum[i] == sum) {
                res++;
            }
        }
        // foreach(int path in pathSum) {
        //     path += node.val;
        //     if(path == sum) {
        //         res++;
        //     }
        // }
        if(node.val == sum) {
            res++;
        }
        pathSum.Add(node.val);
        FindPaths(node.left, pathSum, sum, ref res);
        if(node.left != null) {
            pathSum.RemoveAt(pathSum.Count - 1);
            for(int i = 0; i < pathSum.Count; i++) {
                pathSum[i] -= node.left.val;
            }
            // foreach(int path in pathSum) {
            //     path -= node.left.val;
            // }
        }
        FindPaths(node.right, pathSum, sum, ref res);
        if(node.right != null) {
            pathSum.RemoveAt(pathSum.Count - 1);
            for(int i = 0; i < pathSum.Count; i++) {
                pathSum[i] -= node.right.val;
            }
            // foreach(int path in pathSum) {
            //     path -= node.right.val;
            // }
        }
    }
}

