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
    
    private Node CopyNodes(Node head, Dictionary<Node, Node> dict) {
        if(head == null) {
            return head;
        }
        if(dict.ContainsKey(head)) {
            return dict[head];
        }           
        dict[head] = new Node(head.val, null, null);  // copy head node 
        dict[head].next = CopyNodes(head.next, dict);  // copy next node 
        dict[head].random = CopyNodes(head.random, dict);  // copy random node
        return dict[head];
    }
}