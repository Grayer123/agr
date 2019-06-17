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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // dfs; hashTable
        // tc:O(n); sc:O(n)
        if(preorder == null && inorder == null || preorder.Length == 0 && inorder.Length == 0) { // corner case
            return null;
        }
        if(preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0 ||preorder.Length != inorder.Length) { // corner case
            throw new ArgumentException("Invalid parameter provided");
        }
        Dictionary<int, int> inDict = new Dictionary<int, int>(); // no duplicates exists in the tree
        for(int i = 0; i < inorder.Length; i++) {
            inDict[inorder[i]] = i; // value - index pair
        }
        int prePos = 0;
        return ConstructTree(preorder, ref prePos, inorder, 0, inorder.Length - 1, inDict);
        
    }
    
    private TreeNode ConstructTree(int[] preorder, ref int prePos, int[] inorder, int inStart, int inEnd, Dictionary<int, int> inDict) {
        if(prePos >= preorder.Length || inStart > inEnd) {
            return null;
        }
        TreeNode node = new TreeNode(preorder[prePos++]);
        int inIdx = inDict[node.val];
        node.left = ConstructTree(preorder, ref prePos, inorder, inStart, inIdx - 1, inDict);
        node.right = ConstructTree(preorder, ref prePos, inorder, inIdx + 1, inEnd, inDict);
        return node;
    }
}