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
        // sort
        // tc:O(nlogn); sc:O(1)
        if(String.IsNullOrEmpty(s) && String.IsNullOrEmpty(t)) {
            return true;
        }
        if(String.IsNullOrEmpty(s) || String.IsNullOrEmpty(t)) {
            return false;
        }
        if(s.Length != t.Length) {
            return false;
        }
        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        // return new String(sArr) == new String(tArr);
        return sArr.SequenceEqual(tArr);
    }
}

