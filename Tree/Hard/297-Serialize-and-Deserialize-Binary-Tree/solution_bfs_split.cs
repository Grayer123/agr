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

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        // bfs; level order traversal
        // tc:O(n); sc:O(n)
        if(root == null) {
            return string.Empty;
        }
        StringBuilder str = new StringBuilder();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if(node != null) {
                str.Append(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
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
        // split string; level order traversal
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(data)) {
            return null;
        }
        string[] arr = data.Split(',');
        if(arr == null || arr.Length == 0) { // corner case
            return null;
        }
        int idx = 0;
        TreeNode root = new TreeNode(Int32.Parse(arr[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            if(idx * 2 + 2 < arr.Length) { // prevent error
                node.left = arr[idx * 2 + 1] == "#" ? null : new TreeNode(Int32.Parse(arr[idx * 2 + 1]));
                node.right = arr[idx * 2 + 2] == "#" ? null : new TreeNode(Int32.Parse(arr[idx * 2 + 2]));
            }
            if(node.left != null) {
                queue.Enqueue(node.left);
            }
            if(node.right != null) {
                queue.Enqueue(node.right);
            }
            idx++;
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));