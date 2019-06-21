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
        // half reverse;
        // tc:O(n); sc:O(1)
        if(head == null || head.next == null) {
            return true;
        }
        ListNode midNode = FindMiddle(head);
        ListNode newHead = ReverseList(midNode.next);
        midNode.next = newHead;
        while(newHead != null) {
            if(head.val != newHead.val) {
                return false;
            }
            head = head.next;
            newHead = newHead.next;
        }
        return true;
    }
    
    private ListNode FindMiddle(ListNode head) {
        ListNode slow = head, fast = head;
        while(fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    
    private ListNode ReverseList(ListNode head) {
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