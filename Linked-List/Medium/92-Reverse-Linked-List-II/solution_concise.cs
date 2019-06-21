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
        // interval reverse in linked list
        // tc:O(n); sc:O(1)
        if(head == null || m >= n) { // corner case
            return head;
        }
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        ListNode begin = dummy;
        ListNode end = null;
        int idx = 1;
        while(idx <= n && head != null) {
            if(idx == m - 1) {
                begin = head;
            }
            if(idx == n) {
                end = head.next;
            }
            head = head.next;
            idx++;
        }
        ReverseInterval(begin, end);
        return dummy.next;
        
    }
    
    private ListNode ReverseInterval(ListNode begin, ListNode end) {
        ListNode cur = begin.next;
        ListNode prev = end;
        while(cur != end) {
            ListNode nextNode = cur.next;
            cur.next = prev;
            prev = cur;
            cur = nextNode;
        }
        begin.next = prev;
        return cur;
    }
}