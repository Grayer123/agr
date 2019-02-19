/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        // use list as auxiliary 
        // TC:O(n); SC:O(n)
        if(head == null || head.next == null) {
            return true;
        }
        ListNode mid = FindMiddle(head); 
        ListNode cur = mid.next;
        mid.next = null; // disconnect
        ListNode newHead = RotateList(cur);
        while(head != null && newHead != null) {
            if(head.val != newHead.val) {
                return false;
            } 
            head = head.next;
            newHead = newHead.next;
        }
        return true;
        
    }
    
    private ListNode FindMiddle(ListNode head) {
        ListNode left = head, right = head;
        while(right.next != null && right.next.next != null) {
            left = left.next;
            right = right.next.next;
        }
        return left;
    }
    
    private ListNode RotateList(ListNode head) {
        ListNode prev = null;
        while(head != null) {
            ListNode tmp = head.next;
            head.next = prev;
            prev = head;
            head = tmp;
        }
        return prev;
    }
}