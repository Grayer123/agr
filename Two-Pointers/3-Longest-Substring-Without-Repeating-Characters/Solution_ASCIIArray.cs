public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // hash table
        // TC:O(n); SC:O(256)
        if(s == null || s.Length == 0) {
            return 0;
        }
        int[] dict = Enumerable.Repeat(-1, 256).ToArray();
        int cur = 0, len = 0, maxLen = 0;
        
        for(int i = 0; i < s.Length; i++) {
            if(dict[s[i]] >= cur) {
                maxLen = Math.Max((i - cur), maxLen);
                cur = dict[s[i]] + 1;
            }
            dict[s[i]] = i;
        }
        return Math.Max(maxLen, s.Length - cur);
    }
}