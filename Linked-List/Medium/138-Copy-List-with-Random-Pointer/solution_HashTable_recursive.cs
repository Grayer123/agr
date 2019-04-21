/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(){}
    public Node(int _val,Node _next,Node _random) {
        val = _val;
        next = _next;
        random = _random;
}
*/
public class Solution {
    public Node CopyRandomList(Node head) {
        // linked list; hash table; recursive
        // tc:O(n); sc:O(n)
        if(head == null) {
            return head;
        }
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        return CopyNodes(head, dict);
       
    }
    private Node CopyNodes(Node node, Dictionary<Node, Node> dict) {
        if(node == null) {
            return node;
        }
        if(dict.ContainsKey(node)) {
            return dict[node];
        }
        Node copyNode = new Node(node.val, null, null);
        dict[node] = copyNode; // need to build connection for 1 and 1' before create random pointer => (if point to itself => stack overflow)
        copyNode.next = CopyNodes(node.next, dict);
        copyNode.random = CopyNodes(node.random, dict);
        
        return copyNode;
    }
}