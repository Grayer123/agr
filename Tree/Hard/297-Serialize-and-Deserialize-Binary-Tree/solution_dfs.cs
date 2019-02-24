/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    // dfs: preorder

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null) {
            return string.Empty;
        }
        StringBuilder str = new StringBuilder();
        PreorderTraverse(root, str);
        return str.ToString();
    }
    
    private void PreorderTraverse(TreeNode node, StringBuilder str) {
        if(node == null) {
            str.Append('#');
            return;
        }
        str.Append(node.val);
        str.Append(' ');
        PreorderTraverse(node.left, str);
        PreorderTraverse(node.right, str);
        
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == null || data == string.Empty) {
            return null;
        }
        int cur = 0;       
        return FetchNode(data, ref cur);
    }
    
    private TreeNode FetchNode(string data, ref int start) {
        if(data[start] == '#') {
            start++;
            return null;
        }
        int end = data.IndexOf(' ', start);
        TreeNode newNode = new TreeNode(Int32.Parse(data.Substring(start, end - start)));
        start = end + 1;
        newNode.left = FetchNode(data, ref start);
        newNode.right = FetchNode(data, ref start);
        return newNode;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));