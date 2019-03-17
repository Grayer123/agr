public class Solution {
    public bool IsValidBST(TreeNode root) {
        // inorder traversal
        // tc:O(n); sc:O(n)
        if(root == null) { // corner case
            return true;
        }
        TreeNode lastNode = null;
        bool isBst = true;
        InorderTraverse(root, ref lastNode, ref isBst);
        return isBst;
    }
    
    private void InorderTraverse(TreeNode node, ref TreeNode lastNode, ref bool isBst) {
        if(node == null || !isBst) {
            return;
        }
        InorderTraverse(node.left, ref lastNode, ref isBst);

        if(lastNode != null && lastNode.val >= node.val) {
            isBst = false;
            return;
        }
        lastNode = node;
        InorderTraverse(node.right, ref lastNode, ref isBst);
    }
}