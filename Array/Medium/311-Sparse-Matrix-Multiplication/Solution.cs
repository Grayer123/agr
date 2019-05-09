public class Solution {
    public int[][] Multiply(int[][] A, int[][] B) {
        // matrix multiply
        // tc:O(n^3); sc:O(1)
        if(A == null || A.Length == 0 || B == null || B.Length == 0) {
            return new int[0][];
        }
        int rowA = A.Length;
        int colA = A[0].Length;
        int colB = B[0].Length;
        int[][] res = new int[rowA][];
        
        for(int i = 0; i < rowA; i++) {
            res[i] = new int[colB];
            for(int j = 0; j < colA; j++) {
                if(A[i][j] != 0) {
                    for(int k = 0; k < colB; k++) {
                        res[i][k] += A[i][j] * B[j][k];
                    }
                }
                
            }
        }
        return res;
    }
}