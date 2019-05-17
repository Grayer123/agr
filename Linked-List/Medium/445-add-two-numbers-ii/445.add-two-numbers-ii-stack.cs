/*
 * @lc app=leetcode id=445 lang=csharp
 *
 * [445] Add Two Numbers II
 Tags
linked-list

Companies
bloomberg | microsoft

You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes first and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Follow up:
What if you cannot modify the input lists? In other words, reversing the lists is not allowed.

Example:

Input: (7 -> 2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 8 -> 0 -> 7
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // stack; linked list
        // tc:O(n); sc:O(n)
        if(l1 == null) { // corner case
            return l2;
        }
        if(l2 == null) { // corner case
            return l1;
        }
        
        Stack<ListNode> stack1 = IterateList(l1);
        Stack<ListNode> stack2 = IterateList(l2);
        ListNode head = new ListNode(-1);
        int carry = 0;
        while(stack1.Count > 0 || stack2.Count > 0 || carry != 0) {
            int val1 = stack1.Count <= 0 ? 0 : stack1.Pop().val;
            int val2 = stack2.Count <= 0 ? 0 : stack2.Pop().val;
            int sum = val1 + val2 + carry;
            carry = sum / 10;
            sum %= 10;
            ListNode newNode = new ListNode(sum);
            newNode.next = head.next;
            head.next = newNode;
        }
        return head.next;
    }
    
    private Stack<ListNode> IterateList(ListNode head) {
        Stack<ListNode> stack = new Stack<ListNode>();
        while(head != null) {
            stack.Push(head);
            head = head.next;
        }
        return stack;
    }
}
