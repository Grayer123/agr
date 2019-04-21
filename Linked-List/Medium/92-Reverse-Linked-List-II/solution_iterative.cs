/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        // linked list reverse
        // tc:O(n); sc:O(1)
        if(head == null || m >= n) { // corner case
            return head;
        }
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        ListNode prev = dummy;
        int count = 1;
        while(head != null && count < m) {
            count++;
            prev = head;
            head = head.next;
        }
        ListNode tail = head; // at node m => after reverse, would be tail
        prev.next = ReverseNodes(ref head, count, n); // return new head
        tail.next = head; // head now points at n + 1 node
        return dummy.next;
    }
    
    private ListNode ReverseNodes(ref ListNode head, int count, int n) {
        ListNode prev = null;
        while(head != null) {
            if(count > n) {
                break;
            }
            ListNode curNext = head.next;
            head.next = prev;
            prev = head;
            head = curNext;
            count++;
        }
        return prev;
    }
}