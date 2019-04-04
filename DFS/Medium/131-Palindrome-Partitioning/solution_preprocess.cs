public class Solution {
    public IList<IList<string>> Partition(string s) {
        // dfs; backtracking + preprocessing palindrome array
        // tc:O(2^n); sc:O(n)
        if(s == null || s.Length == 0) {
            return new List<IList<string>>();
        }
        IList<IList<string>> res = new List<IList<string>>();
        List<string> path = new List<string>();
        bool[,] isPalindrome = ProcessPalindrome(s);
        FindPalindrome(s, res, path, 0, isPalindrome);
        return res;
        
    }
    private void FindPalindrome(string s, IList<IList<string>> res, List<string> path, int pos, bool[,] isPalindrome) {
        if(pos >= s.Length) {
            res.Add(new List<string>(path));  // deep copy
            return;
        }
        for(int i = 0; i < s.Length - pos; i++) {
            if(isPalindrome[pos, pos + i]) {
                path.Add(s.Substring(pos, i + 1));
                FindPalindrome(s, res, path, pos + i + 1, isPalindrome);
                path.RemoveAt(path.Count - 1); // backtracking
            }
        }
    }
    private bool[,] ProcessPalindrome(string s) {
        bool[,] isPalindrome = new bool[s.Length, s.Length];
        for(int i = 0; i < s.Length; i++) {
            isPalindrome[i, i] = true; // s[i] == s[i]
            if(i > 0) {
                isPalindrome[i - 1, i] = s[i - 1] == s[i]; // preprocess adjacent elems
            }
        }
        for(int j = 2; j < s.Length; j++) { // start from interval of 2
            for(int i = 0; i < j - 1; i++) {
                isPalindrome[i, j] = (s[i] == s[j]) && isPalindrome[i + 1, j - 1];
            }
        }
        return isPalindrome;
    }
}