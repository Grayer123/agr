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
        // preorder traversal (iterative)
        // tc:O(n); sc:O(n)
        if(root == null) {
            return String.Empty;
        }
        StringBuilder str = new StringBuilder();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count > 0) {
            TreeNode node = stack.Pop();
            if(node != null) {
                str.Append(node.val);
                stack.Push(node.right); // stack: filo => put right first
                stack.Push(node.left);               
            }
            else {
                str.Append('#');
            }
            str.Append(',');
        }
        str.Length--; // remove the last ,
        return str.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(String.IsNullOrEmpty(data)) {
            return null;
        }
        string[] strArr = data.Split(',');
        int idx = 0;
        return ConstructTree(strArr, ref idx);
    }
    
    private TreeNode ConstructTree(string[] strArr, ref int idx) {
        if(idx >= strArr.Length || strArr[idx] == "#") { // null
            idx++; // need to point to next index
            return null;
        }
        TreeNode node = new TreeNode(Int32.Parse(strArr[idx++]));
        node.left = ConstructTree(strArr, ref idx);
        node.right = ConstructTree(strArr, ref idx);
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));