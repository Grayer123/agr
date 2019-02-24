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
    // tc:O(n); sc:O(n)
    
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
            str.Append("# ");
            return;
        }
        str.Append(node.val + " ");
        PreorderTraverse(node.left, str);
        PreorderTraverse(node.right, str);
        
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == null || data == string.Empty) {
            return null;
        }
        string[] arr = data.Split(' ');
        int cur = 0;       
        return FetchNode(arr, ref cur);
    }
    
    private TreeNode FetchNode(string[] arr, ref int cur) {
        if(arr[cur] == "#") {
            cur++;
            return null;
        }
        TreeNode newNode = new TreeNode(Int32.Parse(arr[cur]));
        cur++;
        newNode.left = FetchNode(arr, ref cur);
        newNode.right = FetchNode(arr, ref cur);
        return newNode;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));