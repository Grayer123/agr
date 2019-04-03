public class Solution {
    public IList<IList<string>> Partition(string s) {
        // dfs; backtracking
        // tc:O(2^n * n); sc:O(n)
        if(s == null || s.Length == 0) {
            return new List<IList<string>>();
        }
        IList<IList<string>> res = new List<IList<string>>();
        List<string> path = new List<string>();
        FindPalindrome(s, res, path, 0);
        return res;
        
    }
    private void FindPalindrome(string s, IList<IList<string>> res, List<string> path, int pos) {
        if(pos >= s.Length) {
            res.Add(new List<string>(path));  // deep copy
            return;
        }
        for(int i = 0; i < s.Length - pos; i++) {
            if(IsPalindrome(s, pos, pos + i)) {
                path.Add(s.Substring(pos, i + 1));
                FindPalindrome(s, res, path, pos + i + 1);
                path.RemoveAt(path.Count - 1); // backtracking
            }
        }
    }
    private bool IsPalindrome(string s, int start, int end) {
        while(start < end && s[start] == s[end]) {
            start++;
            end--;
        }
        return start >= end;
    }
}