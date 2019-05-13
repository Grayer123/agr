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
        // linked list; hash table
        // tc:O(n); sc:O(n)
        if(head == null) {
            return head;
        }
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        Node cur = head;
        while(cur != null) {
            if(!dict.ContainsKey(cur)) {  
                dict[cur] = new Node(cur.val, null, null);  // copy head node 
            }
            if(cur.next != null) {
                if(!dict.ContainsKey(cur.next)) {
                    dict[cur.next] = new Node(cur.next.val, null, null);   // copy next node              
                }
                dict[cur].next = dict[cur.next];  // add the edge for next 
            }
            if(cur.random != null) {
                if(!dict.ContainsKey(cur.random)) {
                    dict[cur.random] = new Node(cur.random.val, null, null);  // copy random node
                }
                dict[cur].random = dict[cur.random];  // add the edge for random
            }           
            cur = cur.next;
        }
        return dict[head];
    }
}