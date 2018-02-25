public class Solution {
    public int KthSmallest(int[,] matrix, int k) {
        //binary search
        //tc:O(nlg(max - min)); sc:O(1)
        if(matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0){ //corner case
            throw new Exception("Invalid input.");
        }
        int n = matrix.GetLength(0); // n*n matrix
        int start = matrix[0, 0], end = matrix[n - 1, n - 1];
        while(start < end){
            int mid = start + (end - start) / 2;
            int cnt = CountSmaller(ref matrix, mid, n);
            if(cnt < k){
                start = mid + 1;
            }
            else{
                end = mid;
            }
        }
        return start;
    }
    
    private int CountSmaller(ref int[,] matrix, int target, int len){
        int res = 0;
        for(int i = 0; i < len; i++){
            int cnt = 0, j = 0;
            while(j < len && matrix[i, j] <= target){
                j++;
                cnt++;
            }
            res += cnt;
        }
        return res;
    }
}