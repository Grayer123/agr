/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 *
 * https://leetcode.com/problems/longest-palindromic-substring/description/
 *
 * algorithms
 * Medium (26.82%)
 * Total Accepted:    512.1K
 * Total Submissions: 1.9M
 * Testcase Example:  '"babad"'
 *
 * Given a string s, find the longest palindromic substring in s. You may
 * assume that the maximum length of s is 1000.
 * 
 * Example 1:
 * 
 * 
 * Input: "babad"
 * Output: "bab"
 * Note: "aba" is also a valid answer.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "cbbd"
 * Output: "bb"
 * 
 * 
 */
public class Solution {
    public string LongestPalindrome(string s) {
        // middle line based spread enumeration + opposite two pointers
        // tc:O(n^2); sc:O(1)
        if(string.IsNullOrEmpty(s)) {
            return s;
        }
        int longest = 0;
        int startIdx = 0;
        for(int i = 0; i < s.Length; i++) {
            int len = FindLongestFrom(s, i, i); // if the palindrome count is odd
            if(longest < len) {
                longest = len;
                startIdx = i - len / 2;
            }
            
            len = FindLongestFrom(s, i, i + 1);  // if the palindrome count is even
            if(longest < len) {
                longest = len;
                startIdx = i - len / 2 + 1;
            }
        }
        return s.Substring(startIdx, longest);
    }

    private int FindLongestFrom(string s, int start, int end) { // two opposite pointers
        int len = 0;
        while(start >= 0 && end < s.Length) {
            if(s[start] != s[end]) {
                break;
            }
            len += start == end ? 1 : 2;
            start--;  
            end++;
        }
        return len;
    }
}

