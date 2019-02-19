/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        // linked list
        // tc:O(n); sc:O(1)
        if(head == null || head.next == null) {
            return head;
        }
        ListNode cur = head;
        int cnt = 1;
        while(cur.next != null) { //find the last node
            cur = cur.next;
            cnt++;
        }
        cur.next = head; // point tail node to the head
        k %= cnt; // k could larger than the length of LinkedList
        for(int i = 0; i < (cnt - k); i++) { // continue move (cnt - k) steps
            cur = cur.next;
        }
        head = cur.next; // new head
        cur.next = null; // cur is now the tail, disconnect
        return head;
    }
}