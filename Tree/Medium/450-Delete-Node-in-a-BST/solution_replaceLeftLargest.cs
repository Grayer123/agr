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
    public TreeNode DeleteNode(TreeNode root, int key) {
        // bst; delete; relace with left largest
        // tc:O(h); sc:O(h)
        if(root == null) {
            return root;
        }
        if(root.val < key) {
            root.right = DeleteNode(root.right, key);
        }
        else if(root.val > key) {
            root.left = DeleteNode(root.left, key);
        }
        else { // find the node 
            if(root.left == null && root.right == null) { // leaf node
                root = null;
            }
            else if(root.left != null) {
                root.val = FindPredecessorValue(root.left);
                root.left = DeleteNode(root.left, root.val);
            }
            else { // not leaf, left child is null; right child is not null
                root.val = FindSuccessorValue(root.right);
                root.right = DeleteNode(root.right, root.val);
            }
        }
        return root;
    }
    
    private int FindPredecessorValue(TreeNode root) {
        if(root.right == null) {
            return root.val;
        }
        return FindPredecessorValue(root.right);
    }
    
    private int FindSuccessorValue(TreeNode root) {
        if(root.left == null) {
            return root.val;
        }
        return FindSuccessorValue(root.left);
    }
}