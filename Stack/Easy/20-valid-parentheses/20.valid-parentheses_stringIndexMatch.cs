/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 *
 * https://leetcode.com/problems/valid-parentheses/description/
 *
 * algorithms
 * Easy (36.18%)
 * Total Accepted:    556K
 * Total Submissions: 1.5M
 * Testcase Example:  '"()"'
 *
 * Given a string containing just the characters '(', ')', '{', '}', '[' and
 * ']', determine if the input string is valid.
 * 
 * An input string is valid if:
 * 
 * 
 * Open brackets must be closed by the same type of brackets.
 * Open brackets must be closed in the correct order.
 * 
 * 
 * Note that an empty string is also considered valid.
 * 
 * Example 1:
 * 
 * 
 * Input: "()"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "()[]{}"
 * Output: true
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "(]"
 * Output: false
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: "([)]"
 * Output: false
 * 
 * 
 * Example 5:
 * 
 * 
 * Input: "{[]}"
 * Output: true
 * 
 * 
 */
public class Solution {
    public bool IsValid(string s) {
        // stack + string matching index
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s)) {
            return true;
        }
        Stack<char> stack = new Stack<char>();
        string pre = "{[(";
        string post = "}])";
        foreach(char ch in s) {
            if(pre.IndexOf(ch) != -1) {
                stack.Push(ch);
            }
            else {
                int idx = post.IndexOf(ch);
                if(idx != -1) {
                    if(stack.Count == 0 || pre[idx] != stack.Pop()) {
                        return false;
                    }
                }
            }
        }
        return stack.Count == 0;
    }
}

