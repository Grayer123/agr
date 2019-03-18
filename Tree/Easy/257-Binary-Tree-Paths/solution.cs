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
    public IList<string> BinaryTreePaths(TreeNode root) {
        // divide and conquer 
        // tc:O(n); sc:O(h)
        if(root == null) {
            return new List<string>();
        }
        List<string> res = new List<string>();
        string path = "";
        FindPaths(root, res, path);
        return res;
    }
    
    // do not use StringBuilder here: reference type, remembered nodes in the left subtree, and append to right subtree
    private void FindPaths(TreeNode node, List<string> res, string path) {
        if(node == null) { // null node
            return;
        }
        path += node.val;
        if(node.left == null && node.right == null) { // leaf node 
            res.Add(path);
            return;
        }
        path += "->";
        FindPaths(node.left, res, path);
        FindPaths(node.right, res, path);
    }
}