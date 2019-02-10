public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // hash table
        // TC:O(n); SC:O(n)
        if(s == null || s.Length == 0) {
            return 0;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int cur = 0, len = 0, maxLen = 0;
        
        for(int i = 0; i < s.Length; i++) {
            if(dict.ContainsKey(s[i]) && dict[s[i]] >= cur) {
                maxLen = Math.Max((i - cur), maxLen);
                cur = dict[s[i]] + 1;
            }
            dict[s[i]] = i;
        }
        return Math.Max(maxLen, s.Length - cur);
    }
}