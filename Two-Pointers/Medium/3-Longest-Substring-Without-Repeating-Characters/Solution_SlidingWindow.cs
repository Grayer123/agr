public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // sliding window + hash table
        // TC:O(n); SC:O(n)
        if(s == null || s.Length == 0) {
            return 0;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0, right = 0;
        int maxLen = 0;
        
        while(right < s.Length) {
            if(dict.ContainsKey(s[right]) && dict[s[right]] >= left) {
                maxLen = Math.Max((right- left), maxLen);
                left = dict[s[right]] + 1;
            }
            dict[s[right]] = right;
            right++;
        }
        return Math.Max(maxLen, (s.Length - left));
    }
}