public class Solution {
    public void Rotate(int[][] matrix) {
        // transpose the matrix
        // tc:O(n^2); sc:O(1)
        if(matrix == null || matrix.Length == 0) { // corner case
            return;
        }
        // transpose the matrix a[i][j] <=> a[j][i]
        for(int i = 0; i < matrix.Length; i++) {
            for(int j = i; j < matrix.Length; j++) { // only the upper half
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;
            }
        }        
        // rotate each row
        // for(int i = 0; i < matrix.Length; i++) {
        //     Array.Reverse(matrix[i]);
        // }
        
        // rotate without system method reverse
        for(int i = 0; i < matrix.Length; i++) {
            int start = 0, end = matrix.Length - 1;
            while(start < end) {
                int tmp = matrix[i][start];
                matrix[i][start] = matrix[i][end];
                matrix[i][end] = tmp;
                start++;
                end--;
            }
        }
    }
}