public class Solution {
    public string ReverseWords(string s) {
        // string
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(s)) {
            return s;
        }
        char[] charArr = s.ToCharArray();
        int pos = 0;
        while(pos < s.Length) {
            int start = pos;
            while(pos < s.Length && s[pos] != ' ') {
                pos++;
            }
            Array.Reverse(charArr, start, pos - start);
            pos++;
        }
        return new String(charArr);
    }
}