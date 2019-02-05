public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        // two opposite pointers
        // tc:O(n^3); sc:O(1)
        if(nums.Length < 4) { //corner case
            return new List<IList<int>>();
        }
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        for(int i = 0; i < nums.Length - 3;) {
            for(int j = i + 1; j < nums.Length - 2;) {
                int left = j + 1, right = nums.Length - 1;
                while(left < right) {
                    int sum = nums[i] + nums[j] + nums[left] + nums[right];
                    if(sum > target) {
                        right--;
                    }
                    else if(sum < target) {
                        left++;
                    }
                    else{
                        res.Add(new List<int>{nums[i], nums[j], nums[left], nums[right]});
                        left++;
                        right--;
                        while(left < right && nums[left] == nums[left - 1]) { // skip duplicates in inner loop
                            left++;
                        }
                        while(left < right && nums[right] == nums[right + 1]) { 
                            right--;
                        }
                    }
                }
                j++;
                while(j < nums.Length - 2 && nums[j - 1] == nums[j]) { // ship duplicates in outer loop
                    j++;
                }
            }
            i++;
            while(i < nums.Length - 3 && nums[i - 1] == nums[i]) {
                    i++;
            }
        }
        return res;
    }
}