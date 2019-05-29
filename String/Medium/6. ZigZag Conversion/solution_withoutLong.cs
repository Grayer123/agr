public class Solution {
    public string Convert(string s, int numRows) {
        // string 
        // tc:O(n); sc:O(n)
        if(String.IsNullOrEmpty(s) || numRows <= 1) {
            return s;
        }
        List<StringBuilder> arr = new List<StringBuilder>();
        for(int i = 0; i < Math.Min(numRows, s.Length); i++) { // initialize
            arr.Add(new StringBuilder());
        }
        bool goingDown = true;
        int pos = 0;
        foreach(char ch in s) {
            arr[pos].Append(ch);
            pos += goingDown ? 1 : -1;
            if(pos == 0 || pos == numRows - 1) {
                goingDown = !goingDown;
            }
        }
        StringBuilder str = new StringBuilder();
        foreach(var st in arr) {
            str.Append(st);
        }
        return str.ToString();
    }
}