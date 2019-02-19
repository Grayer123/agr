/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // linked list + two pointers
        // tc:O(n); sc:O(1)
        if(head == null) {
            return head;
        }
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        ListNode left = dummy, right = dummy;
        for(int i = 0; i < n; i++) {
            right = right.next;
        }
        while(right.next != null) {
            right = right.next;
            left = left.next;
        }
        left.next = left.next.next;
        return dummy.next; // if only one elem in linkedlist, and should be removed
    }
}