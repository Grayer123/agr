public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        // brutal force
        // tc:O(n ^ 2); sc:O(1)
        // time limit exceeded on extreme situation: nums=[1,1,1...], k = 2 (nums is a huge array)
        if(nums == null || nums.Length == 0 || k <= 1) { // all positive in nums
            return 0;
        }
        int product = 1, res = 0;
        for(int i = 0; i < nums.Length; i++) {
            product = nums[i];
            if(nums[i] < k) {
                res++;
            }
            int j = i + 1;
            while(j < nums.Length && nums[j] * product < k) {
                product *= nums[j];
                res++;
                j++;
            }
        }
        return res;
    }
}