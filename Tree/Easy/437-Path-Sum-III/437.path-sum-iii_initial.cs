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
        // TC:O(n^2); SC:O(n)
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
        if(node.val == sum) {
            res++;
        }
        pathSum.Add(node.val);
        FindPaths(node.left, pathSum, sum, ref res);
        FindPaths(node.right, pathSum, sum, ref res);
        pathSum.RemoveAt(pathSum.Count - 1);
        // foreach(int path in pathSum) { // error: Cannot assign to 'path' because it is a 'foreach iteration variable'
        //     path -= node.val;
        // }
        
        for(int i = 0; i < pathSum.Count; i++) {
            pathSum[i] -= node.val;
        }
    }
}