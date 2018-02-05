public class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        //tc:O(m^n)
        if(matrix == null){ //corner case 
            return false;
        }
        int len = matrix.GetLength(0), wid = matrix.GetLength(1);
        if(len == 0 || wid == 0){ //corner case
            return false;
        }
        //from bottom left to top left(ignore the one in bottom left)
        for(int i = len - 2; i >= 0; i--){
            if(!IsEqualInDiagonal(i + 1, 1, len, wid, ref matrix)){
                return false;
            }
        }
        //from top right to top left (ignore the first one)
        for(int j = 1; j <= wid - 1; j++){
            if(!IsEqualInDiagonal(1, j + 1, len, wid, ref matrix)){
                return false;
            }
        }
        return true;
    }
    
    //utility function: check the equality of elem in the diagonal
    bool IsEqualInDiagonal(int m, int n, int len, int wid, ref int[,] matrix){
        while(m < len && n < wid){
            if(matrix[m-1, n-1] != matrix[m, n]){
                return false;
            }
            m++;
            n++;
        }
        return true;
    }
}