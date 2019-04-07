public class Solution {
    public IList<string> LetterCombinations(string digits) {
        // dfs + backtracking 
        // tc:O(3^n); sc:O(n)
        if(digits == null || digits == String.Empty) {
            return new List<string>();
        }
        string[] dict = {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        IList<string> res = new List<string>();
        StringBuilder str = new StringBuilder();
        FindCombination(digits, res, str, dict, 0);
        return res;
    }
    
    private void FindCombination(string digits, IList<string> res, StringBuilder str, string[] dict, int pos) {
        if(pos >= digits.Length) {
            res.Add(str.ToString());
            return;
        }
        int index = digits[pos] - '0' - 2; // get the index in dict      
        foreach(var ch in dict[index]) {
            str.Append(ch);
            FindCombination(digits, res, str, dict, pos + 1);
            str.Length--; // backtracking
        }
    }
}