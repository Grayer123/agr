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
        // divide and conquer 
        //
        if(preorder == null && inorder == null || preorder.Length == 0 && inorder.Length == 0) { // corner case
            return null;
        }
        if(preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0 ||preorder.Length != inorder.Length) { // corner case
            throw new ArgumentException("Invalid parameter provided");
        }
        int curPre = 0;
        return ConstructNodes(preorder, ref curPre, inorder, 0, inorder.Length - 1);
        
    }
    
    private TreeNode ConstructNodes(int[] preorder, ref int curPre, int[] inorder, int startInorder, int endInorder) {
        if(startInorder > endInorder) {
            return null;
        }
        if(startInorder == endInorder) {
            curPre++;
            return new TreeNode(inorder[startInorder]);
        }
        int index = Array.IndexOf(inorder, preorder[curPre]); // find the root
        curPre++;
        TreeNode root = new TreeNode(inorder[index]);
        root.left = ConstructNodes(preorder, ref curPre, inorder, startInorder, index - 1);
        root.right = ConstructNodes(preorder, ref curPre, inorder, index + 1, endInorder);
        return root;
    }
}