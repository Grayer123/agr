public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //dictionary;
        //TC:O(n); SC:O(n)
        if(nums.Length < 2){//corner case
            return new int[]{};
        }
        int[] res = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                res[0] = dict[target - nums[i]];
                res[1] = i;
                return res;
            }
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], i);
            }
        }
        return res;
    }
}