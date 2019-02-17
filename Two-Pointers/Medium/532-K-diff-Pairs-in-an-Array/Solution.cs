public class Solution {
    public int FindPairs(int[] nums, int k) {
        // two same directional pointers + sort
        // tc:O(nlogn); sc:O(1)
        if(nums == null || nums.Length < 2 || k < 0) {
            return 0;
        }
        Array.Sort(nums);
        int left = 0, right = 0;
        int res = 0;
        k = Math.Abs(k);
        while(right < nums.Length) {
            if(left == right || nums[right] - nums[left] < k) {
                right++;
            }
            else if(nums[right] - nums[left] > k) {
                left++;
            }
            else{
                res++;
                left++;
                right++;
                while(left < right && nums[left] == nums[left - 1]) {
                    left++;
                }
                while(right < nums.Length && nums[right] == nums[right - 1]) {
                    right++;
                }
            }
        }
        return res;
    }
}