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
        if(head == null || head.next == null) {
            return head;
        }
        ListNode odd = head;
        ListNode evenHead = head.next;
        ListNode even = evenHead;
        // head.next = null; // disconnect
        ListNode cur = even.next;
        int count = 3;
        while(cur != null) {
            if(count % 2 == 1) {
                odd.next = cur;
                odd = cur;
            }
            else {
                even.next = cur;
                even = cur;
            }
            cur = cur.next;
            count++;
        }
        even.next = null; // disconnect
        odd.next = evenHead;
        return head;
    }
}