class Solution {
public:
    int twoSumClosest(vector<int> &nums, int target) {
        // Two opposite pointers
        // TC:O(nlogn); SC:O(1)
        if(nums.size() < 2) {
            throw std::invalid_argument( "invalid input" );
        }
        sort(nums.begin(), nums.end());
        int left = 0, right = nums.size() - 1;
        int minDiff = INT_MAX;
        while(left < right) {
            int sum = nums[left] + nums[right];
            minDiff = min(minDiff, abs(sum - target));
            if(sum > target) {
                right--;
            }
            else if (sum == target) {
                return 0;
            }
            else {
                left++;
            }
        }
        return minDiff;
    }
};