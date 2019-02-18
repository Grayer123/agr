public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        // two pointers
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0 || k <= 1) { // all positive in nums
            return 0;
        }
        int left = 0, right = 0;
        int product = 1, res = 0;
        while(right < nums.Length) {
            product *= nums[right];
            while(left <= right && product >= k) {
                product /= nums[left];
                left++;
            }
            res += right - left + 1; // could be empty (empty: left = right + 1)
            right++;
        }
        return res;
    }
}