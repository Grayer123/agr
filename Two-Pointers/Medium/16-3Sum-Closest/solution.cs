public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        // two opposite pointers
        // tc:O(n^2); sc:O(1)
        if(nums.Length < 3) { //corner case
            throw new Exception("Invalid input.");
        }
        Array.Sort(nums);
        int minSum = 0;
        int minDiff = int.MaxValue;
        for(int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1, right = nums.Length - 1;
            while(left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                int diff = Math.Abs(sum - target);
                if(diff < minDiff) {
                    minDiff = diff;
                    minSum = sum;
                }
                if(sum > target) {
                    right--;
                }
                else if(sum == target) {
                    return target;
                }
                else {
                    left++;
                }
            }
        }
        return minSum;
    }
}