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
        // dp
        // tc:O(n^2); sc:O(n^2)
        if(s == null || s.Length == 0) {
            return string.Empty;
        }
        int startIdx = 0, maxLen = 1;
        
        bool[,] isPalindrome = new bool[s.Length, s.Length];
        for(int i = 0; i < s.Length; i++) {
            isPalindrome[i, i] = true; // s[i] == s[i]
            if(i > 0) {
                isPalindrome[i - 1, i] = s[i - 1] == s[i]; // process adjacent elems
                if(s[i] == s[i - 1] && maxLen == 1) { // handle adjacent elems max len
                    startIdx = i - 1;
                    maxLen = 2;
                }
                
            }
        }
        for(int j = 2; j < s.Length; j++) { // start from interval of 2
            for(int i = 0; i < j - 1; i++) {
                if(s[i] == s[j] && isPalindrome[i + 1, j - 1]) {
                    isPalindrome[i ,j] = true;
                    if(j - i + 1 > maxLen) {
                        startIdx = i;
                        maxLen = j - i + 1;
                    }
                }
            }
        }
        return s.Substring(startIdx, maxLen);
    }
}
