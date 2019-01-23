/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // hash table
        // tc:O(n); sc:O(n)
        if(head == null || head.next == null) { //corner case
            return false;
        }
        HashSet<ListNode> dict = new HashSet<ListNode>();
        while(head != null) {
            if(dict.Contains(head)) {
                return true;
            }
            dict.Add(head);
            head = head.next;
        }
        return false;
    }
}