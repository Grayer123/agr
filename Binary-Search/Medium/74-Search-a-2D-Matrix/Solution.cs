public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        //tc:O(lg(mn)); sc:O(mn)
        //based on the question, could convert this 2d matrix to 1d array
        if(matrix == null){
            return false;
        }
        int numOfRow = matrix.GetLength(0), numOfCol = matrix.GetLength(1);
        if(numOfRow == 0 || numOfCol == 0){ //corner case
            return false;
        }
        int[] arr = new int[numOfRow * numOfCol];
        int count = 0;
        for(int i = 0; i < numOfRow; i++){
            for(int j = 0; j < numOfCol; j++){
                arr[count++] = matrix[i, j];
            }
        }
        int start = 0, end = arr.Length - 1;
        while(start < end){
            int mid = start + (end - start) / 2;
            if(arr[mid] == target){
                return true;
            }
            else if(arr[mid] < target){
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return arr[start] == target;
    }
}