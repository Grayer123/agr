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
        // tc:O(n); sc:O(1)
        if(head == null) {
            return head;
        }
        ListNode prev = null;
        ReverseNodes(ref head, ref prev);
        return prev;
    }
    private void ReverseNodes(ref ListNode cur, ref ListNode prev) {
        if(cur == null) {
            return;
        }
        ListNode curNext = cur.next;
        cur.next = prev;
        prev = cur;
        cur = curNext;
        ReverseNodes(ref cur, ref prev);
    }
}