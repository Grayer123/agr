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
            
            if(left > right || up > down) { // make sure index still in scope
                break;
            }
            for(int i = right; i >= left; i--) { // from right to left
                res.Add(matrix[down][i]);
            }
            down--;
            
            for(int j = down; j >= up; j--) { // from down to up
                res.Add(matrix[j][left]);
            }
            left++;
        }
        return res; 
    }
}