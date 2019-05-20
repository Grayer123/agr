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
        if(head == null || head.next == null) {
            return head;
        }
        ListNode curOdd = head;
        ListNode evenHead = head.next;
        ListNode curEven = evenHead;
        while(curEven != null && curEven.next != null) {
            curOdd.next = curEven.next;
            curOdd = curOdd.next;
            curEven.next = curEven.next.next;
            curEven = curEven.next;
        }
        curOdd.next = evenHead;
        return head;
    }
}