public class Solution {
    public string FindLongestWord(string s, IList<string> d) {
        // two parallel pointers
        // tc:O(mn); sc:O(1)
        if(d == null || d.Count == 0) {
            return string.Empty;
        }
        int minOrder = Int32.MaxValue;
        string maxString = string.Empty;
        foreach(var t in d) {
            int left = 0, right = 0, order = 0;
            while(left < t.Length && right < s.Length) {
                if(t[left] == s[right]) {
                    left++;
                    right++;                    
                }
                else {
                    right++;
                }
            }
            if(left == t.Length) {
                if(maxString.Length < t.Length || maxString.Length == t.Length && CompareOrder(t, maxString)) {
                    minOrder = order;
                    maxString = t;
                }
            }
        }
        return maxString;
    }
    
    private bool CompareOrder(string s, string t) {
        int cur = 0;
        while(cur < s.Length && cur < t.Length) {
            if(s[cur] < t[cur]) {
                return true;
            }
            else if(s[cur] > t[cur]) {
                return false;
            }
            cur++;
        }
        return cur == s.Length;
    }
}