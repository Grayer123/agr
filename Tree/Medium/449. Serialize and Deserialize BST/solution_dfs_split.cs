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
    // preorder traversal + inorder property of bst; recursive
    // tc: O(n); sc:O(n)

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null) {
            return String.Empty;
        }
        StringBuilder str = new StringBuilder();
        PreorderTraversal(root, str);
        str.Length--; // remove last ','
        return str.ToString();
    }
    
    private void PreorderTraversal(TreeNode node, StringBuilder str) {
        if(node == null) {
            return;
        }
        str.Append(node.val).Append(',');
        PreorderTraversal(node.left, str);
        PreorderTraversal(node.right, str);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(String.IsNullOrEmpty(data)) {
            return null;
        }
        string[] strArr = data.Split(',');
        int idx = 0;
        return ConstructTree(strArr, ref idx, Int32.MinValue, Int32.MaxValue);
    }
    
    private TreeNode ConstructTree(string[] strArr, ref int idx, int minVal, int maxVal) {
        if(idx >= strArr.Length) {
            return null;
        }
        int nodeVal = Int32.Parse(strArr[idx]);
        if(nodeVal < minVal || nodeVal > maxVal) {
            return null;
        }
        TreeNode node = new TreeNode(nodeVal);
        idx++;
        node.left = ConstructTree(strArr, ref idx, minVal, node.val);
        node.right = ConstructTree(strArr, ref idx, node.val, maxVal);
        return node;
        
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));