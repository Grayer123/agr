/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 *
 * https://leetcode.com/problems/word-pattern/description/
 *
 * algorithms
 * Easy (34.71%)
 * Total Accepted:    134.9K
 * Total Submissions: 388.7K
 * Testcase Example:  '"abba"\n"dog cat cat dog"'
 *
 * Given a pattern and a string str, find if str follows the same pattern.
 * 
 * Here follow means a full match, such that there is a bijection between a
 * letter in pattern and a non-empty word in str.
 * 
 * Example 1:
 * 
 * 
 * Input: pattern = "abba", str = "dog cat cat dog"
 * Output: true
 * 
 * Example 2:
 * 
 * 
 * Input:pattern = "abba", str = "dog cat cat fish"
 * Output: false
 * 
 * Example 3:
 * 
 * 
 * Input: pattern = "aaaa", str = "dog cat cat dog"
 * Output: false
 * 
 * Example 4:
 * 
 * 
 * Input: pattern = "abba", str = "dog dog dog dog"
 * Output: false
 * 
 * Notes:
 * You may assume pattern contains only lowercase letters, and str contains
 * lowercase letters that may be separated by a single space.
 * 
 */
public class Solution {
    public bool WordPattern(string pattern, string str) {
        // hash table + ContainsValue
        // tc:O(n^2); sc:(n)
        if(string.IsNullOrEmpty(pattern) && string.IsNullOrEmpty(str)) {
            return true;
        }
        if(string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(str)) {
            return false;
        }
        Dictionary<char, string> dictPat = new Dictionary<char, string>();
        string[] strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries); // remove empty entries(assuming more than one empty space between words)
        if(pattern.Length != strArr.Length) {
            return false;
        }
        for(int i = 0; i < pattern.Length; i++) {
            if(dictPat.ContainsKey(pattern[i])) {
                if(dictPat[pattern[i]] != strArr[i]) {
                    return false;
                }
            }
            else {
                if(dictPat.ContainsValue(strArr[i])) { // expensive operation: O(n)
                    return false;
                }
                dictPat[pattern[i]] = strArr[i];
            }
        }
        return true;
    }
}

