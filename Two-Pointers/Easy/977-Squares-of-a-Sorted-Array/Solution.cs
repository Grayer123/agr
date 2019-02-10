public class Solution {
    public int[] SortedSquares(int[] nums) {
        // two opposite pointers
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0) {
            return new int[0];
        }
        int left = 0, right = nums.Length - 1;
        int[] res = new int[nums.Length];
        int cur = nums.Length - 1;
        while(left <= right) {
            int squareLeft = nums[left] * nums[left];
            int squareRight = nums[right] * nums[right];
            if(squareLeft < squareRight) {
                res[cur--] = squareRight;
                right--;
            }
            else {
                res[cur--] = squareLeft;
                left++;
            }
        }
        return res;
    }
}