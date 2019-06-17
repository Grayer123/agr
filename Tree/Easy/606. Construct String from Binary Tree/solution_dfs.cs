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
    public string Tree2str(TreeNode t) {
        // preorder
        // tc:O(n); sc:O(n)
        if(t == null) {
            return "";
        }
        string left = Tree2str(t.left);
        string right = Tree2str(t.right);
        string str = t.val.ToString();
        if(left == "" && right == "") {
            return str;
        }
        if(right == "") {
            return str + "(" + left + ")";
        }
        return str + "(" + left + ")" + "(" + right + ")";
    }
}