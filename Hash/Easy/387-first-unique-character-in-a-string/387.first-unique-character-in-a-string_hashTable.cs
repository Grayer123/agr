/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 *
 * https://leetcode.com/problems/first-unique-character-in-a-string/description/
 *
 * algorithms
 * Easy (49.59%)
 * Total Accepted:    251.5K
 * Total Submissions: 506.5K
 * Testcase Example:  '"leetcode"'
 *
 * 
 * Given a string, find the first non-repeating character in it and return it's
 * index. If it doesn't exist, return -1.
 * 
 * Examples:
 * 
 * s = "leetcode"
 * return 0.
 * 
 * s = "loveleetcode",
 * return 2.
 * 
 * 
 * 
 * 
 * Note: You may assume the string contain only lowercase letters.
 * 
 */
public class Solution {
    public int FirstUniqChar(string s) {
        // ascii array as hash table
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s)) {
            return -1;
        }
        int[] dict = Enumerable.Repeat(-1, 256).ToArray();
        for(int i = 0; i < s.Length; i++) {
            if(dict[s[i]] == -1) {
                dict[s[i]] = i;
            }
            else if(dict[s[i]] >= 0){
                dict[s[i]] = -2;
            }
        }
        int minIdx = s.Length;
        for(int i = 0; i < dict.Length; i++) {
            if(dict[i] >= 0) {
                minIdx = minIdx <= dict[i] ? minIdx : dict[i];
            }
        }
        return minIdx == s.Length ? -1 : minIdx;
    }
}

