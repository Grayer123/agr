public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        // two pointers
        // TC:O(n^2); SC:O(1)
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        int res = 0;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1, right = nums.Length - 1;
            while(left < right) {
                if(nums[left] + nums[right] < target - nums[i]) {
                    res += right - left; // since {left, right} matched, [left, left+1,...,right-1] also matches
                    left++;
                }
                else {
                    right--;
                }
                
            }
        }
        return res;
     }
}