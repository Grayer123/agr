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
        if(string.IsNullOrEmpty(s)) {
            return new List<string>();
        }
        IList<string> res = new List<string>();
        StringBuilder path = new StringBuilder();
        BuildAddress(s, res, path, 0, 0);
        return res;
    }
    
    private void BuildAddress(string s, IList<string> res, StringBuilder path, int pos, int dotCount) {
        if(pos >= s.Length || dotCount >= 4) {
            if(pos == s.Length && dotCount == 4) { 
                string st = path.ToString();
                st = st.Substring(0, st.Length - 1); // remove the unwanted trailing .
                res.Add(st);
            }        
            return;
        }
        //path.Append(s[pos] + '.');  // when '0' + '.' => ascii add first
        path.Append(s.Substring(pos, 1) + ".");  // only get 1 digit ('0' can only be 1 digit)
        BuildAddress(s, res, path, pos + 1, dotCount + 1);
        path.Length -= 2; // backtracking
            
        if(s[pos] != '0' && pos + 1 < s.Length) { // get 2 digits (first as '0' excluded)
            path.Append(s.Substring(pos, 2) + ".");
            BuildAddress(s, res, path, pos + 2, dotCount + 1);
            path.Length -= 3; // backtracking
        }
        if(s[pos] != '0' && pos + 2 < s.Length) { // get 3 digits (first as '0' excluded)
            string str = s.Substring(pos, 3);
            if(Int32.Parse(str) < 256) {
                path.Append(str + ".");
                BuildAddress(s, res, path, pos + 3, dotCount + 1);
                path.Length -= 4; // backtracking
            }              
        }
    }
}

