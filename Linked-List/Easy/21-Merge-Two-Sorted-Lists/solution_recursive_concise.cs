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
        return MergeNodes(l1, l2);
    }
    private ListNode MergeNodes(ListNode l1, ListNode l2) {
        if(l1 == null) {
            return l2;
        }
        if(l2 == null) {
            return l1;
        }
        if(l1.val < l2.val) {
            l1.next = MergeNodes(l1.next, l2);
            return l1;
        }
        else {
            l2.next = MergeNodes(l1, l2.next);
            return l2;
        }
    }
}