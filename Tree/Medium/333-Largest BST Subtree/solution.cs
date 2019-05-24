/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class ResultType {
    public bool isBst;
    public int count;
    public long minVal;
    public long maxVal;
    
    public ResultType(bool b, int c, long min, long max) {
        isBst = b;
        count = c;
        minVal = min;
        maxVal = max;
    }
}

public class Solution {
    public int LargestBSTSubtree(TreeNode root) {
        // bst; post order
        // tc:O(n); sc:O(n)
        if(root == null) {
            return 0;
        }
        int maxCount = 1;
        FindMaxBst(root, ref maxCount);
        return maxCount;
    }
    
    private ResultType FindMaxBst(TreeNode node, ref int maxCount) {
        if(node == null) {
            return new ResultType(true, 0, (Int32.MaxValue + (long)1), (Int32.MinValue - (long)1));
            
        }
        ResultType left = FindMaxBst(node.left, ref maxCount);
        ResultType right = FindMaxBst(node.right, ref maxCount);
        if(left.isBst && right.isBst) {
            if(node.val > left.maxVal && node.val < right.minVal) {
                int curCount = left.count + right.count + 1;
                maxCount = Math.Max(curCount, maxCount);
                return new ResultType(true, curCount, Math.Min(left.minVal, node.val), Math.Max(right.maxVal, node.val));
            }
        }
        return new ResultType(false, 0, 0, 0);
    }
}