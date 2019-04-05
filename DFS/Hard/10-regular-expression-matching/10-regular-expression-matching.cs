/*
 * @lc app=leetcode id=10 lang=csharp
 *
 * [10] Regular Expression Matching
 *
 * https://leetcode.com/problems/regular-expression-matching/description/
 *
 * algorithms
 * Hard (25.05%)
 * Total Accepted:    288.4K
 * Total Submissions: 1.1M
 * Testcase Example:  '"aa"\n"a"'
 *
 * Given an input string (s) and a pattern (p), implement regular expression
 * matching with support for '.' and '*'.
 * 
 * 
 * '.' Matches any single character.
 * '*' Matches zero or more of the preceding element.
 * 
 * 
 * The matching should cover the entire input string (not partial).
 * 
 * Note:
 * 
 * 
 * s could be empty and contains only lowercase letters a-z.
 * p could be empty and contains only lowercase letters a-z, and characters
 * like . or *.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input:
 * s = "aa"
 * p = "a"
 * Output: false
 * Explanation: "a" does not match the entire string "aa".
 * 
 * 
 * Example 2:
 * 
 * 
 * Input:
 * s = "aa"
 * p = "a*"
 * Output: true
 * Explanation: '*' means zero or more of the precedeng element, 'a'.
 * Therefore, by repeating 'a' once, it becomes "aa".
 * 
 * 
 * Example 3:
 * 
 * 
 * Input:
 * s = "ab"
 * p = ".*"
 * Output: true
 * Explanation: ".*" means "zero or more (*) of any character (.)".
 * 
 * 
 * Example 4:
 * 
 * 
 * Input:
 * s = "aab"
 * p = "c*a*b"
 * Output: true
 * Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore
 * it matches "aab".
 * 
 * 
 * Example 5:
 * 
 * 
 * Input:
 * s = "mississippi"
 * p = "mis*is*p*."
 * Output: false
 * 
 * 
 */
public class Solution {
    public bool IsMatch(string s, string p) {
        // dfs 
        // tc:O(); sc:O()
        if(s == null && p == null) { // corner case: based on the question, no need
            return true;
        }
        if(s == null || p == null) { // corner case: based on the question, no need
            return false; 
        }
        if(s == string.Empty) {
            return CheckEmpty(p);
        }
        if(p == string.Empty) {
            return false;
        }
        char s1 = s[0];
        char p1 = p[0];
        char p2 = p.Length > 1 ? p[1] : '0';
        if(p2 == '*') {
            if(Compare(s1, p1)) {
                return IsMatch(s.Substring(1), p) || IsMatch(s, p.Substring(2));
            }
            else {
                return IsMatch(s, p.Substring(2));
            }
        }
        else {
            return Compare(s1, p1) && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
    
    private bool Compare(char a, char b) {
        return a == b || b == '.';
    }
    
    private bool CheckEmpty(string p) {
        if(p.Length % 2 != 0) { // * only appears in the second, fourth, ... (even) place
            return false;
        }
        for(int i = 1; i < p.Length; i += 2) {
            if(p[i] != '*') {
                return false;
            }
        }
        return true;
    }
}

