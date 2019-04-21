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
        // linked list; 
        // tc:O(n); sc:O(1)
        if(head == null) {
            return head;
        }
        CopyNext(head);
        CopyRandom(head);
        return SplitList(head);
       
    }
    private void CopyNext(Node node) { // create copyNode for each node, and append to its next
        while(node != null) {
            Node copyNode = new Node(node.val, null, null);
            Node curNext = node.next;
            node.next = copyNode;
            copyNode.next = curNext;
            node = curNext;
        }
    }
    
    private void CopyRandom(Node node) { //copy random link to the copied node
        while(node != null) {
            Node randomNode = node.random;
            if(randomNode != null) {
                node.next.random = randomNode.next; // node.next => the copyNode for node
            }
            
            node = node.next.next;
        }
    }
    
    private Node SplitList(Node node) { //spilt the original node and the copied node 
        Node copyHead = node.next;
        while(node != null) {
            Node copyNode = node.next;
            Node nextNode = copyNode.next;
            node.next = nextNode; // disconnect
            if(nextNode != null) {
                copyNode.next = nextNode.next;
            }
            node = nextNode;
            
        }
        return copyHead;
    }
}