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
        // linked list
        // tc:O(n); sc:O(n)
        if(head == null) {
            return head;
        }
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        Node cur = head;
        while(cur != null) {
            if(!dict.ContainsKey(cur)) {
                Node copy = new Node(cur.val, null, null);
                dict[cur] = copy;
            }
            if(cur.next != null) {
                if(!dict.ContainsKey(cur.next)) {
                    Node copyNext = new Node(cur.next.val, null, null);
                    dict[cur.next] = copyNext;
                }
                dict[cur].next = dict[cur.next];
            }
            if(cur.random != null) {
                if(!dict.ContainsKey(cur.random)) {
                    Node copyRandom = new Node(cur.random.val, null, null);
                    dict[cur.random] = copyRandom;
                }
                dict[cur].random = dict[cur.random];
            }           
            cur = cur.next;
        }
        return dict[head];
    }
}