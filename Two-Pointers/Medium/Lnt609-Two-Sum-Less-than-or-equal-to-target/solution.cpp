class Solution {
public:
    int twoSum5(vector<int> &nums, int target) {
        // two opposite pointers
        // tc:O(n); sc:O(1)
        if(nums.size() < 2) {
            return 0;
        }
        sort(nums.begin(), nums.end());
        int left = 0, right = nums.size() - 1;
        int res = 0;
        while(left < right) {
            if(nums[left] <= target - nums[right]) { // means (left, any from left+1 to right) could meet the criteria
                res += right - left;
                left++;
            }
            else {
                right--;
            }
        }
        return res;
    }
};