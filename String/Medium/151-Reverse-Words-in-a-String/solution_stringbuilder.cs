public class Solution {
    public string ReverseWords(string s) {
        // reverse twice; string; stringBuilder, char[]
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(s)) {
            return s;
        }
        // s = s.Trim();
        char[] strArr = s.ToCharArray();
        Array.Reverse(strArr);
        StringBuilder str = new StringBuilder();
        int pos = 0;
        while(pos < strArr.Length) {
            if(strArr[pos] == ' ') { // skipping the ' '
                pos++;
                continue; 
            }
            int start = pos;
            while(pos < strArr.Length && strArr[pos] != ' ') {
                pos++;
            }
            Array.Reverse(strArr, start, pos - start);
            str.Append(strArr, start, pos - start);
            str.Append(' ');
        }
        if(str.Length > 0) { // remove the last ' '
            str.Length--;
        }
        return str.ToString();
    }
}