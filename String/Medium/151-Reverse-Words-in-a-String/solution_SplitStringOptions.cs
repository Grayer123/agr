public class Solution {
    public string ReverseWords(string s) {
        // string manipulation
        // tc:O(n); sc:O(n)
        if(s == null || string.IsNullOrEmpty(s)) {
            return s;
        }
        string[] strArr = s.Split(' ',  StringSplitOptions.RemoveEmptyEntries);
        StringBuilder str = new StringBuilder();
        for(int i = strArr.Length - 1; i >= 0; i--) {
            str.Append(strArr[i]);
            if(i != 0) {
                str.Append(' ');
            }
        }
        return str.ToString();
    }
}