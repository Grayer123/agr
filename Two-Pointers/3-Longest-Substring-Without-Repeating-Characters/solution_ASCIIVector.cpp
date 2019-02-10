class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        // hash table
        // TC:O(n); SC:O(256)
        if(s.size() == 0) {
            return 0;
        }
        vector<int> dict(256, -1);
        int cur = 0, len = 0, maxLen = 0;
        
        for(int i = 0; i < s.size(); i++) {
            if(dict[s[i]] >= cur) {
                maxLen = max((i - cur), maxLen);
                cur = dict[s[i]] + 1;
            }
            dict[s[i]] = i;
        }
        return maxLen = maxLen < s.size() - cur ? s.size() - cur : maxLen;
    }
};