public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        // two sum (opposite direction)
        // TC:O(n^2); SC:O(1)
        if(nums == null || nums.Length < 3) {
            return new List<IList<int>>();
        }
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        for(int i = 0; i < nums.Length - 2; i++) { // to ensure at least 2 nums left 
            int left = i + 1, right = nums.Length - 1;
            while(left < right) {
                if(nums[i] > (0 - nums[left] - nums[right])) {
                    right--;
                }
                else if(nums[i] < (0 - nums[left] - nums[right])) {
                    left++;
                }
                else {                    
                    res.Add(new List<int>{nums[i], nums[left], nums[right]});
                    left++;
                    right--;
                    while(left < right && nums[left] == nums[left - 1]) { // skip duplicates for 2nd, 3rd num
                        left++;
                    }
                    while(left < right && nums[right] == nums[right + 1]) {
                        right--;
                    }
                }    
            }
            while(i < nums.Length - 2 && nums[i] == nums[i + 1]) { // skip duplicates for the 1st num
                i++;
            }
        }
        return res;
    }
}