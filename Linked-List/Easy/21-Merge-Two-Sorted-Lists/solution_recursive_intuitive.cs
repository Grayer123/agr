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
        // merge sorted list; recursive
        // tc:O(n); sc:O(1)
        return MergeNodes(ref l1, ref l2);
    }
    private ListNode MergeNodes(ref ListNode l1, ref ListNode l2) {
        if(l1 == null) {
            return l2;
        }
        if(l2 == null) {
            return l1;
        }
        ListNode head = new ListNode(-1);
        if(l1.val < l2.val) {
            head.next = l1;
            head.next.next = MergeNodes(ref l1.next, ref l2);
        }
        else {
            head.next = l2;
            head.next.next = MergeNodes(ref l1, ref l2.next);
        }
        return head.next;
    }
}