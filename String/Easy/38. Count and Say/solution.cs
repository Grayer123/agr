public class Solution {
    public string CountAndSay(int n) {
        // string
        // tc:O(n^2); sc:O(n)
        if(n < 1) {
            return "0";
        }
        if(n == 1) {
            return "1"; 
        }
        string s = "1";
        for(int i = 2; i <= n; i++) {
            StringBuilder str = new StringBuilder();
            int pos = 0;
            while(pos < s.Length) {
                char ch = s[pos++];
                int count = 1;
                while(pos < s.Length && s[pos] == ch) {
                    pos++;
                    count++;
                }
                str.Append(count).Append(ch);
            }
            s = str.ToString();
        }
        return s;
    }
}