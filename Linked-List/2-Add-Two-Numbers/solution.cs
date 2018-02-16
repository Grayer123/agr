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
        //linked list;
        //TC:O(n); SC:O(1)
        if(l1 == null){//corner case
            return l2;
        }
        if(l2 == null){//corner case
            return l1;
        }
        int carry = 0;
        ListNode newHead = new ListNode(-1);
        ListNode cur = newHead;
        while(l1 != null || l2 != null){
            int val1 = l1 == null ? 0 : l1.val;
            int val2 = l2 == null ? 0 : l2.val;
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;
            ListNode node = new ListNode((val1 + val2 + carry) % 10);
            carry = (val1 + val2 + carry) / 10;
            cur.next = node;
            cur = cur.next;
        }
        cur.next = carry == 1 ? new ListNode(carry) : null;
        return newHead.next;
    }
}