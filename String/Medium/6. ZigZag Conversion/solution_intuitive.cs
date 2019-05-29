public class Solution {
    public string Convert(string s, int numRows) {
        // string + total simutation (build 2d array)
        // tc:O(n); sc:O(n^2)
        if(String.IsNullOrEmpty(s) || numRows < 1) {
            return String.Empty;
        }
        char[,] arr = new char[numRows, s.Length];
        int pos = 0;
        int col = 0;
        while(pos < s.Length) {
            int up = 0, down = numRows - 2;
            while(up < numRows && pos < s.Length) { // moving down
                arr[up++, col] = s[pos++];
            }
            col++;
            while(down > 0 && pos < s.Length) { // moving up
                arr[down--, col++] = s[pos++];
            }
        }
        StringBuilder str = new StringBuilder();
        for(int i = 0; i < numRows; i++) {
            for(int j = 0; j < s.Length; j++) {
                if(arr[i, j] != '\0') {
                    str.Append(arr[i, j]);
                }
            }
        }
        return str.ToString();
    }
}