public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        // sliding window + hash table
        // tc:O(n); sc:O(n)
        if(s == null || s == string.Empty) {
            return 0;
        }
        int maxLen = 0;
        int left = 0, right = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        while(right < s.Length) {
            dict[s[right]] = dict.ContainsKey(s[right]) ? ++dict[s[right]] : 1;
            while(dict.Count == 3 && left < right) {
                maxLen = Math.Max(maxLen, right - left);
                dict[s[left]]--;
                if(dict[s[left]] == 0) {
                    dict.Remove(s[left]);
                }
                left++;
            }
            right++;
        }
        return Math.Max(maxLen, right - left);
    }
}