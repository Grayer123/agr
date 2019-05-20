/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        // linked list; 
        // tc:O(n); sc:O(1)
        if(head == null) {
            return head;
        }
        ListNode cur = head;
        ListNode lastOdd = head;
        ListNode evenHead = new ListNode(-1);
        ListNode curEven = evenHead;
        while(cur != null && cur.next != null) {
            curEven.next = cur.next;
            curEven = cur.next;
            lastOdd = cur;
            cur.next = cur.next.next;
            cur = cur.next;
        }
        curEven.next = null; // disconnect
        if(cur != null) {
            cur.next = evenHead.next;
        }
        else {
            lastOdd.next = evenHead.next;
        }
        return head;
    }
}