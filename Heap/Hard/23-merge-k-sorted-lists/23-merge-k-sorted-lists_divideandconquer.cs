/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 *
 * https://leetcode.com/problems/merge-k-sorted-lists/description/
 *
 * algorithms
 * Hard (33.82%)
 * Total Accepted:    370K
 * Total Submissions: 1.1M
 * Testcase Example:  '[[1,4,5],[1,3,4],[2,6]]'
 *
 * Merge k sorted linked lists and return it as one sorted list. Analyze and
 * describe its complexity.
 * 
 * Example:
 * 
 * 
 * Input:
 * [
 * 1->4->5,
 * 1->3->4,
 * 2->6
 * ]
 * Output: 1->1->2->3->4->4->5->6
 * 
 * 
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        // divide and conquer
        // tc:O(nlogk); sc:O(1)
        if(lists == null || lists.Length == 0) {
            return null;
        }
        return DivideAndConquer(lists, 0, lists.Length - 1);
    }
    
    private ListNode DivideAndConquer(ListNode[] lists, int start, int end) {
        if(start >= end) {
            return lists[start];
        }
        int mid = start + (end - start) / 2;
        ListNode l1 = DivideAndConquer(lists, start, mid);
        ListNode l2 = DivideAndConquer(lists, mid + 1, end);
        return MergeTwoList(l1, l2);
    }
    
    private ListNode MergeTwoList(ListNode node1, ListNode node2) {
        ListNode head = new ListNode(-1);
        ListNode cur = head;
        while(node1 != null && node2 != null) {
            if(node1.val <= node2.val) {
                cur.next = node1;
                cur = node1;
                node1 = node1.next;
            }
            else {
                cur.next = node2;
                cur = node2;
                node2 = node2.next;
            }
        }
       cur.next = node1 == null ? node2 : node1;
        return head.next;
    }
}
