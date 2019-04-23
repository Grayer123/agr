/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // linked list; follow up (considerring if l1 is super long, l2 is short)
        // tc:O(n); sc:O(n)
        if(l1 == null || l1.val == 0 && l1.next == null) {
            return l2;
        }
        if(l2 == null || l2.val == 0 && l2.next == null) {
            return l1;
        }
        ListNode head = new ListNode(-1);
        ListNode cur = head;
        int carry = 0;
        while(l1 != null && l2 != null) {
            int sum = l1.val + l2.val + carry;
            carry = sum / 10;
            cur.next = new ListNode(sum % 10);
            cur = cur.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        cur.next = l1 != null ? AddNumber(l1, carry) : AddNumber(l2, carry);
        return head.next;
    }
    private ListNode AddNumber(ListNode list, int carry) { // recursively add one list with carry
        if(carry == 0) {
            return list;
        }
        if(list == null) {
            return new ListNode(carry);
        }
        int sum = list.val + carry;
        carry = sum / 10;
        list.val = sum % 10;
        list.next = AddNumber(list.next, carry);
        return list;
    }
}