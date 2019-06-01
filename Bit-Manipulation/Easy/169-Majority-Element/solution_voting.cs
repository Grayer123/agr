public class Solution {
    public int MajorityElement(int[] nums) {
        // Boyer-Moore Voting Algorithm
        // tc:O(n); sc:O(1)
        if(nums == null || nums.Length == 0) {
            throw new ArgumentException("Invalid input.");
        }
        int count = 0;
        int candidate = nums[0];
        foreach(int num in nums) {
            if(count == 0) {
                candidate = num;
            }
            count = candidate == num ? ++count : --count;
        }
        return candidate;
    }
}