public class Solution {
    public string ReverseWords(string s) {
        // reverse twice; string; stringBuilder, char[]
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(s)) {
            return s;
        }
        s = s.Trim();
        char[] strArr = s.ToCharArray();
        Array.Reverse(strArr);
        StringBuilder str = new StringBuilder();
        int pos = 0;
        while(pos < strArr.Length) {
            int start = pos;
            while(pos < strArr.Length && strArr[pos] != ' ') {
                pos++;
            }
            Array.Reverse(strArr, start, pos - start);
            str.Append(strArr, start, pos - start);
            if(pos != strArr.Length) {
                str.Append(' ');
            }
            while(pos < strArr.Length && strArr[pos] == ' ') { // skip all the empty space
                pos++;
            }
        }
        return str.ToString();
    }
}