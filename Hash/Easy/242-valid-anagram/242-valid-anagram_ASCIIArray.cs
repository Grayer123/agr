/*
 * [242] Valid Anagram
 * Given two strings s and t , write a function to determine if t is an anagram of s.
* 
* Example 1:
* 
* Input: s = "anagram", t = "nagaram"
* Output: true
* Example 2:
* 
* Input: s = "rat", t = "car"
* Output: false
* Note:
* You may assume the string contains only lowercase alphabets.
* 
* Follow up:
* What if the inputs contain unicode characters? How would you adapt your solution to such case?
*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        // ascii array as hash table
        // tc:O(n); sc:O(26)
        if(string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) {
            return true;
        }
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) {
            return false;
        }
        if(s.Length != t.Length) {
            return false;
        }
        int[] dict = new int[26]; 
        for(int i = 0; i < s.Length; i++) {
            dict[s[i] - 'a']++;
            dict[t[i] - 'a']--;
        }
        foreach(var val in dict) {
            if(val != 0) {
                return false;
            }
        }
        return true;
    }
}

