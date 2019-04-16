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
        // hash table
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s)) {
            return -1;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            if(!dict.ContainsKey(s[i])) {
                dict[s[i]] = i;
            }
            else {
                dict[s[i]] = -1;
            }
        }
        int minIdx = s.Length;
        foreach(var key in dict.Keys) {
            if(dict[key] != -1) {
                minIdx = minIdx <= dict[key] ? minIdx : dict[key];
            }
        }
        return minIdx == s.Length ? -1 : minIdx;
    }
}

