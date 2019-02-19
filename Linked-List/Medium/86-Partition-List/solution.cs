/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        // linked list + two parallel pointers
        // tc:O(n); sc:O(1)
        if(head == null || head.next == null) {
            return head;
        }
        ListNode small = new ListNode(-1);
        ListNode large = new ListNode(-1);
        ListNode curSmall = small, curLarge = large;
        while(head != null) {
            if(head.val < x) {
                curSmall.next = head;
                curSmall = curSmall.next;
            }
            else {
                curLarge.next = head;
                curLarge = curLarge.next;
            }
            head = head.next;
        }
        curLarge.next = null; // disconnect to avoid endless loop
        curSmall.next = large.next;
        return small.next;
    }
}