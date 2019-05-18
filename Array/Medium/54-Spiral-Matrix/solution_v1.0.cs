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
        while(left <= right && up <= down) {
            for(int i = left; i <= right; i++) { // from left to right
                res.Add(matrix[up][i]);
            }
            up++; // the upper most elem covered

            for(int j = up; j <= down; j++) { // from up to down
                res.Add(matrix[j][right]);
            }
            right--;
            
            if(left > right || up > down) {
                break;
            }
            for(int k = right; k >= left; k--) { // from right to left
                res.Add(matrix[down][k]);
            }
            down--;
            
            for(int l = down; l >= up; l--) { // from down to up
                res.Add(matrix[l][left]);
            }
            left++;
        }
        return res; 
    }
}