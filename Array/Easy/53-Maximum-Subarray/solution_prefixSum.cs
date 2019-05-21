public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums == null || nums.Length == 0) {
            throw new ArgumentException("The argument provided is invalid.");
        }
        int max = nums[0];
        int sum = 0;
        foreach(int num in nums) {
            sum += num;
            max = Math.Max(sum, max);
            sum = sum < 0 ? 0 : sum;  // not contributing to the onward subarray sum, set to 0
        }
        return max;
    }
}