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
    public TreeNode BstFromPreorder(int[] preorder) {
        // preorder traversal + inorder property of bst; recursive
        // tc: O(n); sc:O(n)
        if(preorder == null || preorder.Length == 0) {
            return null;
        }
        int idx = 0;
        return ConstructTree(preorder, ref idx, Int32.MinValue, Int32.MaxValue);
    }
    
    private TreeNode ConstructTree(int[] preorder, ref int idx, int minVal, int maxVal) {
        if(idx >= preorder.Length) {
            return null;
        }
        int nodeVal = preorder[idx];
        if(nodeVal < minVal || nodeVal > maxVal) {
            return null;
        }
        TreeNode node = new TreeNode(nodeVal);
        idx++;
        node.left = ConstructTree(preorder, ref idx, minVal, node.val);
        node.right = ConstructTree(preorder, ref idx, node.val, maxVal);
        return node;
        
    }
}