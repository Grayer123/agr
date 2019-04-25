public class Solution {
    public int MaxSubArray(int[] nums) {
        // prefix sum
        // tc:O(n); sc:O(n)
        if(nums == null || nums.Length == 0) {
            throw new Exception("The argument provided is invalid.");
        }
        // int[] prefixSum = new int[nums.Length + 1]; // no need to define prefix array here
        // prefixSum[0] = 0;  // could directly use sum 
        int maxSum = nums[0];
        int minPrefix = 0;
        int sum = 0;
        for(int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            int curSum = sum - minPrefix;
            maxSum = Math.Max(maxSum, curSum);
            minPrefix = Math.Min(minPrefix, sum);
        }
        return maxSum;
    }
}