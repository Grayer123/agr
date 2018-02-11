public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        //tc:O(m+n); sc:O(1)
        if(matrix == null){ //corner case
            return false;
        }
        int numOfRows = matrix.GetLength(0), numOfCols = matrix.GetLength(1);
        if(numOfRows == 0 || numOfCols == 0){ //corner case
            return false;
        }
        int curRow = numOfRows - 1, curCol = 0;  //set begin point at left bottom corner 
        while(curRow >= 0 && curCol < numOfCols){
            if(matrix[curRow, curCol] == target){
                return true;
            }
            else if(matrix[curRow, curCol] < target){
                curCol++;
            }
            else{
                curRow--;
            }
        }
        return false;
    }
}