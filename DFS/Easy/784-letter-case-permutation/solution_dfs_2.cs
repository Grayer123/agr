/*
 * @lc app=leetcode id=784 lang=csharp
 *
 * [784] Letter Case Permutation
 *
 * https://leetcode.com/problems/letter-case-permutation/description/
 *
 * algorithms
 * Easy (55.53%)
 * Total Accepted:    41K
 * Total Submissions: 73.7K
 * Testcase Example:  '"a1b2"'
 *
 * Given a string S, we can transform every letter individually to be lowercase
 * or uppercase to create another string.  Return a list of all possible
 * strings we could create.
 * 
 * 
 * Examples:
 * Input: S = "a1b2"
 * Output: ["a1b2", "a1B2", "A1b2", "A1B2"]
 * 
 * Input: S = "3z4"
 * Output: ["3z4", "3Z4"]
 * 
 * Input: S = "12345"
 * Output: ["12345"]
 * 
 * 
 * Note:
 * 
 * 
 * S will be a string with length between 1 and 12.
 * S will consist only of letters or digits.
 * 
 * 
 */

public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        // dfs; backtracking
        // tc:O(2^n * n); sc:O(n)
        if(s == null) {
            return new List<string>();
        }
        IList<string> res = new List<string>();
        StringBuilder str = new StringBuilder();
        FindPermutation(s, res, str, 0);
        return res;
        
    }   
    private void FindPermutation(string s, IList<string> res, StringBuilder str, int pos) {
        if(pos == s.Length) {
            res.Add(str.ToString());
            return;
        }
        if(!Char.IsLetter(s[pos])) {
            str.Append(s[pos]);
            FindPermutation(s, res, str, pos + 1);
            str.Length--; // backtracking
        }
        else {
            str.Append(Char.ToLower(s[pos]));
            FindPermutation(s, res, str, pos + 1);
            str.Length--; // backtracking
            str.Append(Char.ToUpper(s[pos]));
            FindPermutation(s, res, str, pos + 1);
            str.Length--; // backtracking
        }       
    }
}

