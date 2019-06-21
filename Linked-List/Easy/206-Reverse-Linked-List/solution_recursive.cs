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
        // linked list reverse; recursive
        // tc:O(n); sc:O(n)
        if(head == null || head.next == null) {
            return head;
        }
        ListNode newHead = ReverseList(head.next);  // give back a reversed linked list of the rest, not including me
        head.next.next = head; // handling me situation
        head.next = null;
        return newHead;
    }
}