public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        // brutal force
        // tc:O(nk); sc:O(1)
        if(nums == null || nums.Length == 0 || nums.Length < k) {
            return new int[0];
        }
        int[] res = new int[nums.Length - k + 1];
        for(int i = 0; i <= nums.Length - k; i++) {
            int max = nums[i];
            for(int j = 0; j < k; j++) {
                max = Math.Max(max, nums[i + j]);
            }
            res[i] = max;
        }
        return res;
    }
}