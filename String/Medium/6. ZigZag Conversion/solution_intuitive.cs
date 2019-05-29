public class Solution {
    public string Convert(string s, int numRows) {
        // string + total simutation (build 2d array)
        // tc:O(n); sc:O(n^2)
        if(String.IsNullOrEmpty(s) || numRows < 1) {
            return String.Empty;
        }
        char[,] arr = new char[numRows, s.Length];
        int pos = 0;
        int row = 0, col = 0;
        while(pos < s.Length) {
            if(row == 0) {
                while(row < numRows && pos < s.Length) {
                    arr[row, col] = s[pos];
                    pos++;
                    row++;
                }
                row = Math.Max(0, row - 2);
                col++;
            }
            
            if(pos >= s.Length) {
                break;
            }
            if(row != 0 && pos < s.Length) {
                arr[row--, col++] = s[pos++];
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