public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        //tc:O(lg(mn)); sc:O(1)
        if(matrix == null){
            return false;
        }
        int numOfRow = matrix.GetLength(0), numOfCol = matrix.GetLength(1);
        if(numOfRow == 0 || numOfCol == 0){ //corner case
            return false;
        }

        int start = 0, end = matrix.Length - 1; //take 2d matrix as 1d array
        while(start < end){
            int mid = start + (end - start) / 2;
            int row = mid / numOfCol;  //get corresponding row in 2d
            int col = mid % numOfCol;  //get corresponding column in 2d
            if(matrix[row, col] == target){
                return true;
            }
            else if(matrix[row, col] < target){
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return matrix[start / numOfCol, start % numOfCol] == target;
    }
}