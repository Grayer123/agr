/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        // linked list; reverse
        // tc:O(n); sc:O(1)
        if(head == null) {
            return head;
        }
        ListNode prev = null;
        while(head != null) {
            ListNode curNext = head.next;
            head.next = prev;
            prev = head;
            head = curNext;
        }
        return prev;
    }
}