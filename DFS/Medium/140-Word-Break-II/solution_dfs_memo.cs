public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        // dfs + memo search
        // TC:O(n^3); sc:O(n)
        if(s == null || s == string.Empty || wordDict == null || wordDict.Count == 0) {
            return new List<string>();
        }
        HashSet<string> hash = wordDict.ToHashSet();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        return GetWords(s, hash, dict);
    }
    
    private List<string> GetWords(string s, HashSet<string> hash, Dictionary<string, List<string>> dict) {
        if(dict.ContainsKey(s)) {
            return dict[s];
        }
        List<string> results = new List<string>();
        if(s.Length == 0) {
            return results;
        }
        if(hash.Contains(s)) {
            results.Add(s);
        }
        for(int len = 1; len < s.Length; len++) {
            string word = s.Substring(0, len);
            if(!hash.Contains(word)) {
                continue;
            }
            string suffix = s.Substring(len);
            List<string> segaments = GetWords(suffix, hash, dict);
            
            foreach(var seg in segaments) {
                results.Add(word + " " + seg);
            }
        }
        dict.Add(s, results);
        return results;
    }
}