class Solution {
public:
    bool wordBreak(string s, unordered_set<string>& wordDict) {
        // DP; SR;
        //TC:O(n^2); SC:O(n)
        int n = s.size();
        //state
        bool f[n + 1];
        fill_n(f, n + 1, false);
        //initialization
        f[0] = true;
        int maxLen = getMaxLen(wordDict);
        //function
        for(int i = 1; i <= n; i++){
            for(int j = 0; j < i; j++){
                if(f[j] && wordDict.count(s.substr(j, i - j)) > 0){
                    f[i] = true;
                    break;
                }
            }
        }
        return f[n];
    }
private:
    int getMaxLen(const unordered_set<string> &dict){
        int len = 0;
        for(auto word : dict){
            len = len > word.size() ? len : word.size();
        }
        return len;
    }
};