/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams

Tags
hash-table | string

Companies
amazon | bloomberg | facebook | uber | yelp

Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]
Note:

All inputs will be in lowercase.
The order of your output does not matter.

 */
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // hashtable + counting array
        // tc:O(nk); sc:O(nk)
        if(strs == null || strs.Length == 0) {
            return new List<IList<string>>();
        }
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        foreach(string str in strs) {
            int[] countArr = new int[26];
            foreach(char ch in str) {
                countArr[ch - 'a']++;
            }
            StringBuilder sb = new StringBuilder();
            foreach(int num in countArr) {
                sb.Append(num);
                sb.Append('#');
            }
            string st = sb.ToString();
            if(!dict.ContainsKey(st)) {
                dict[st] = new List<string>{str};
            }
            else {
                dict[st].Add(str);
            }
        }
        
        return dict.Values.ToList();
    }
}

