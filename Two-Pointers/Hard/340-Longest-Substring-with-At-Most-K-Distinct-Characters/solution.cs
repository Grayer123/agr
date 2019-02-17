public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        // sliding window + hash table
        // tc:O(n); sc:O(n)
        if(s == null || s.Length == 0 || k < 1) {
            return 0;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0, right = 0;
        int maxLen = 0;
        while(right < s.Length) {
            dict[s[right]] = dict.ContainsKey(s[right]) ? ++dict[s[right]] : 1;
            if(dict.Count == k + 1) {
                maxLen = Math.Max(maxLen, right - left);
                while(dict.Count == k + 1) {
                    dict[s[left]]--;
                    if(dict[s[left]] == 0) {
                        dict.Remove(s[left]);
                    }
                    left++;
                }
            }
            right++;
        }
        return Math.Max(maxLen, right - left);
    }
}