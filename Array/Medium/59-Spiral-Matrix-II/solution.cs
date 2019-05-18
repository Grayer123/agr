public class Solution {
    public int[][] GenerateMatrix(int n) {
        // array
        // tc:O(n^2); sc:O(1)
        if(n <= 0) {
            return new int[0][];
        }
        int[][] res = new int[n][];
        for(int i = 0; i < n; i++) { // initialize the result array
            res[i] = Enumerable.Repeat(0, n).ToArray();
        }
        int left = 0, right = n - 1;
        int up = 0, down = n - 1;
        int count = 1;
        while(left <= right && up <= down) { // from left to right
            for(int i = left; i <= right; i++) {
                res[up][i] = count++;
            }
            up++;
            for(int j = up; j <= down; j++) { // from up to down
                res[j][right] = count++;
            }
            right--;
            for(int i = right; i >= left; i--) { // from right to left
                res[down][i] = count++;
            }
            down--;
            for(int j = down; j >= up; j--) { // from down to up
                res[j][left] = count++;
            }
            left++;
        }
        return res;
    }
}