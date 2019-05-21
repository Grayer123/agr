public class Solution {
    public void Rotate(int[][] matrix) {
        // transpose the matrix
        // tc:O(n^2); sc:O(1)
        if(matrix == null || matrix.Length == 0) { // corner case
            return;
        }
        Array.Reverse(matrix);
        // transpose the matrix a[i][j] <=> a[j][i]
        for(int i = 0; i < matrix.Length; i++) {
            for(int j = i; j < matrix.Length; j++) { // only the upper half
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;
            }
        }        
    }
}