class Solution {
public:
    int twoSum6(vector<int> &nums, int target) {
        // two pointers: opposite direction
        // TC:O(nlogn); SC:O(1)
        if(nums.size() < 2) {
            return 0;
        }
        int res = 0;
        int left = 0, right = nums.size() - 1;
        sort(nums.begin(), nums.end());
        while(left < right) {
            if(nums[left] < target - nums[right]) {
                left++;
            }
            else if(nums[left] > target - nums[right]) {
                right--;
            }
            else {
                res++;
                left++;
                right--;
                while(left < right && nums[left] == nums[left - 1]) { // skip the same elem
                    left++;
                }
                while(left < right && nums[right] == nums[right + 1]) { // skip the same elem
                    right--;
                }
            }
        }     
        return res;
    }
};