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
        while(pos < s.Length) {
            int up = 0, down = numRows - 2;
            while(up < numRows && pos < s.Length) { // moving down (0 ~ rows -1)
                arr[up++].Append(s[pos++]);
            }
            while(down > 0 && pos < s.Length) { // moving up (rows - 2 ~ 1)
                arr[down--].Append(s[pos++]);
            }
        }
        StringBuilder str = new StringBuilder();
        foreach(var st in arr) {
            str.Append(st);
        }
        return str.ToString();
    }
}