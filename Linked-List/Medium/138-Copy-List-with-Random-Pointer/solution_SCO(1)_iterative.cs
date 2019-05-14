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
        ConnectRandom(head);
        return SplitList(head);
    }
    
    private void CopyNext(Node head) {  // create copyNode for each node, and append to its next
       while(head != null) {
           Node copyNode = new Node(head.val, null, null);
           copyNode.next = head.next;
           head.next = copyNode;
           head = copyNode.next;
       }
    }
    
    private void ConnectRandom(Node head) {  //copy random link to the copied node
        while(head != null) {
            if(head.random != null) {
                head.next.random = head.random.next;
            }
            head = head.next.next;
        }
    }
    
    private Node SplitList(Node head) { //spilt the original node and the copied node 
        Node copyHead = head.next;
        while(head != null) {
            Node oldNext = head.next.next;
            if(oldNext != null) {
                head.next.next = oldNext.next;
            }
            head.next = oldNext;
            head = oldNext;
        }
        return copyHead;
    }
}