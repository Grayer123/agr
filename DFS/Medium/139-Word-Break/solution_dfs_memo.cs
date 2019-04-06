public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        // dfs + memory search
        /// tc:O(n^2); sc:O(n)
        if(s == null || s == string.Empty) {
            return true;
        }
        HashSet<string> hash = new HashSet<string>(wordDict);
        Dictionary<string, bool> memo = new Dictionary<string, bool>();
        
        return FindWord(s, hash, memo);
    }
    private bool FindWord(string s, HashSet<string> hash, Dictionary<string, bool> memo) {
        if(s.Length == 0 || hash.Contains(s)) {
            return true;
        }
        if(memo.ContainsKey(s)) {
            return memo[s];
        }
        for(int len = 1; len < s.Length; len++) {
            string prefix = s.Substring(0, len);
            if(!hash.Contains(prefix)) {
                continue;
            }
            string suffix = s.Substring(len);
            if(memo.ContainsKey(suffix)) {
                if(memo[suffix]) {
                    return true;
                }
            }
            else if(FindWord(suffix, hash, memo)) {
                memo[s] = true;
                return true;
            }
        }
        memo[s] = false;
        return false;
    }
}