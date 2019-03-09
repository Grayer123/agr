public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // sorting 
        // tc:O(nlogn); sc:O(1)
        if(nums.Length < 2) {
            return false;
        }
        Array.Sort(nums);
        int left = 0, right = 1;
        while(right < nums.Length) {
            if(nums[left] == nums[right]) {
                return true;
            }
            left++;
            right++;
        }
        return false;
    }
}