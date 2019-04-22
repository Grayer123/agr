/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        // merge sorted list; iterative
        // tc:O(n); sc:O(1)
        ListNode head = new ListNode(-1);
        ListNode cur = head;
        while(l1 != null && l2 != null) {
            if(l1.val <= l2.val) {
                cur.next = l1;
                cur = l1;
                l1 = l1.next;
            }
            else {
                cur.next = l2;
                cur = l2;
                l2 = l2.next;
            }
        }
       cur.next = l1 == null ? l2 : l1;
        return head.next;
    }
}