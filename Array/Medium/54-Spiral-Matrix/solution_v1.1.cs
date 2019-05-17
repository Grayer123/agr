public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        // array; spiral traversal
        // tc:O(n^2); sc:O(1)
        if(matrix == null || matrix.Length == 0) {
            return new List<int>();
        }
        IList<int> res = new List<int>();
        int rows = matrix.Length, cols = matrix[0].Length;
        int left = 0, right = cols - 1;
        int up = 0, down = rows - 1;
        int dir = 0;
        while(left <= right && up <= down) {
            if(dir % 4 == 0) {
                for(int i = left; i <= right; i++) { // from left to right
                    res.Add(matrix[up][i]);
                }
                up++; // the upper most elem covered
            }
            else if(dir % 4 == 1) {
                for(int j = up; j <= down; j++) { // from up to down
                    res.Add(matrix[j][right]);
                }
                right--;
            }
            else if(dir % 4 == 2) {
                for(int k = right; k >= left; k--) { // from right to left
                    res.Add(matrix[down][k]);
                }
                down--;
            }
            else if(dir % 4 == 3) {
                for(int l = down; l >= up; l--) { // from down to up
                    res.Add(matrix[l][left]);
                }
                left++;
            }
            dir++;
        }
        return res; 
    }
}