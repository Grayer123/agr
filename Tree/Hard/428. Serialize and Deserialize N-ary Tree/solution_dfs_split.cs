/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Codec {
    // preorder traversal; recursive
    // tc:O(n); sc:O(n)

    // Encodes a tree to a single string.
    public string serialize(Node root) {
        // preorder; recursive
        // add number of children after node.val, in order to know when to terminate
        if(root == null) {
            return String.Empty;
        }
        StringBuilder str = new StringBuilder();
        TraverseTree(root, str);
        return str.ToString();
    }
    
    private void TraverseTree(Node node, StringBuilder str) {
        if(node == null) {
            return;
        } 
        str.Append(node.val).Append(',');
        str.Append(node.children.Count).Append(',');
        foreach(var child in node.children) {
            TraverseTree(child, str);
        }
    }

    // Decodes your encoded data to tree.
    public Node deserialize(string data) {
        if(String.IsNullOrEmpty(data)) {
            return null;
        }
        string[] strArr = data.Split(',');
        int idx = 0;
        return ConstructTree(strArr, ref idx);
    }
    
    private Node ConstructTree(string[] strArr, ref int idx) {
        if(idx >= strArr.Length) { // null
            return null;
        }
        Node node = new Node();
        node.val = Int32.Parse(strArr[idx++]);
        int childCount = Int32.Parse(strArr[idx++]);
        node.children = new List<Node>(childCount);
        for(int i = 0; i < childCount; i++) {
            node.children.Add(ConstructTree(strArr, ref idx));
        }
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));