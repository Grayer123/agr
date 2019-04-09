/*
 * @lc app=leetcode id=93 lang=csharp
 *
 * [93] Restore IP Addresses
 *
 * https://leetcode.com/problems/restore-ip-addresses/description/
 *
 * algorithms
 * Medium (31.02%)
 * Total Accepted:    134.2K
 * Total Submissions: 432.5K
 * Testcase Example:  '"25525511135"'
 *
 * Given a string containing only digits, restore it by returning all possible
 * valid IP address combinations.
 * 
 * Example:
 * 
 * 
 * Input: "25525511135"
 * Output: ["255.255.11.135", "255.255.111.35"]
 * 
 * 
 */
public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        // dfs + backtracking 
        // tc:O(n); sc:O(n)
        if(string.IsNullOrEmpty(s) || s.Length < 4 || s.Length > 12) { // corner case
            return new List<string>();
        }
        IList<string> res = new List<string>();
        List<string> path = new List<string>();
        BuildAddress(s, res, path, 0);
        return res;
    }
    
    private void BuildAddress(string s, IList<string> res, List<string> path, int pos) {
        if(pos >= s.Length || path.Count >= 4) {
            if(pos == s.Length && path.Count == 4) { 
                StringBuilder sb = new StringBuilder();
                foreach(string st in path) { // build the string with .
                    sb.Append(st);
                    sb.Append('.');
                }
                sb.Length--; // remove the unwanted trailing .
                res.Add(sb.ToString());
            }        
            return;
        }
        for(int i = 1; i <= 3 && pos + i <= s.Length; i++) { // how many digits to get
            string str = s.Substring(pos, i);
            if(IsValid(str)) {
                path.Add(str);
                BuildAddress(s, res, path, pos + i);
                path.RemoveAt(path.Count - 1); // backtracking
            }
        }
    }
    
    private bool IsValid(string str) {
        if(str[0] == '0') {
            return str == "0";  // avoid 01, 011 => ip address start with 0 could only be 0.*
        } 
        int num = Int32.Parse(str);
        return num > 0 && num < 256;
    }
}
