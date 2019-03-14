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
    public bool IsValidBST(TreeNode root) {
        // inorder traversal
        // tc:O(n); sc:O(n)
        if(root == null) { // corner case
            return true;
        }
        List<int> list = new List<int>();
        GetInorderSequence(root, list);
        for(int i = 0; i < list.Count - 1; i++) {
            if(list[i] >= list[i + 1]) {
                return false;
            }
        }
        return true;
    }
    
    private void GetInorderSequence(TreeNode node, List<int> list) {
        if(node == null) {
            return;
        }
        GetInorderSequence(node.left, list);
        list.Add(node.val);
        GetInorderSequence(node.right, list);
    }
}