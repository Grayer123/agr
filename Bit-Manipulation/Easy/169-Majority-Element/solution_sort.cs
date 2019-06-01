public class Solution {
    public int MajorityElement(int[] nums) {
        // sort + math
        // tc:O(nlogn); sc:O(1)
        if(nums == null || nums.Length == 0) {
            throw new ArgumentException("Invalid input.");
        }
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}