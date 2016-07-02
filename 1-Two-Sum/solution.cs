public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //dictionary;
        //TC:O(n); SC:O(n)
        if(nums.Length < 2){//corner case
            throw new ArgumentException("Invalid input");
        }
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                return new int[]{dict[target - nums[i]], i};
            }
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], i);
            }
        }
        throw new ArgumentException("No two sum solution.");
    }
}