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
        IList<int> list = new List<int>();
        while(head != null) {
            list.Add(head.val);
            head = head.next;
        }
        return IsPalindromeList(list);
    }
    
    private bool IsPalindromeList(IList<int> list) {
        int left = 0, right = list.Count - 1;
        while(left < right) {
            if(list[left] != list[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}