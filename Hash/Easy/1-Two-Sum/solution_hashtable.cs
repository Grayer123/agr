public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // hash table
        // tc:O(n); sc:O(n)
        if(nums == null || nums.Length < 2) {
            return new int[0];
        }
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int num = target - nums[i];
            if(dict.ContainsKey(num)) {
                return new int[] { dict[num], i };
            }
            dict[nums[i]] = i;
        }
        return new int[0];
    }
}