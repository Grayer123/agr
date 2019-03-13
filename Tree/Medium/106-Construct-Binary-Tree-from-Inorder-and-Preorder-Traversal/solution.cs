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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        // divide and conquer 
        // tc:O(n); sc:O(n)
        if(postorder == null && inorder == null || postorder.Length == 0 && inorder.Length == 0) {
            return null;
        }
        if(postorder == null || inorder == null || postorder.Length == 0 || inorder.Length == 0 ||postorder.Length != inorder.Length) {
            throw new ArgumentException("Invalid parameter provided");
        }
        int curPost = postorder.Length - 1;
        return ConstructNodes(postorder, ref curPost, inorder, 0, inorder.Length - 1);
        
    }
    
    private TreeNode ConstructNodes(int[] postorder, ref int curPost, int[] inorder, int startIn, int endIn) {
        if(startIn > endIn) {
            return null;
        }
        if(startIn == endIn) {
            curPost--;
            return new TreeNode(inorder[startIn]);
        }
        int index = Array.IndexOf(inorder, postorder[curPost]); // find the root
        curPost--;
        TreeNode root = new TreeNode(inorder[index]);
        root.right = ConstructNodes(postorder, ref curPost, inorder, index + 1, endIn);
        root.left = ConstructNodes(postorder, ref curPost, inorder, startIn, index - 1);
        return root;
    }
}