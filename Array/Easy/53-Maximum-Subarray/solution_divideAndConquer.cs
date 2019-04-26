public class Solution {
    public int MaxSubArray(int[] nums) {
        // divide and conquer 
        // tc:O(n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            throw new Exception("The argument provided is invalid.");
        }
        return DivideAndConquer(nums, 0, nums.Length - 1);
    }
    
    private int DivideAndConquer(int[] nums, int start, int end) {
        if(start >= end) {
            return nums[end];
        }
        int mid = start + (end - start) / 2;
        return Math.Max(Math.Max(DivideAndConquer(nums, start, mid), DivideAndConquer(nums, mid + 1, end)), FindCrossingMaxSum(nums, start, mid, end));
    }
    
    private int FindCrossingMaxSum(int[] nums, int start, int mid, int end) {
        int sum = 0;
        int leftSum = nums[mid];
        for(int i = mid; i >= start; i--) {
            sum += nums[i];
            leftSum = Math.Max(sum, leftSum);
        }
        sum = 0;
        int rightSum = nums[mid + 1];
        for(int i = mid + 1; i <= end; i++) {
            sum += nums[i];
            rightSum = Math.Max(sum, rightSum);
        }
        return leftSum + rightSum;
    }
}